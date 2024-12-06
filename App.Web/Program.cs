using App.Data;
using App.Data.Repositories;
using App.Web.Common.Mailer;
using App.Web.Services.AppUser;
using App.Web.WebConfig;
using App.Web.WebConfig.Consts;
using AspNetCoreHero.ToastNotification;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorOptions(options =>
{
	options.ViewLocationFormats.Add("/{0}.cshtml");
});

builder.Services.AddDbContext<WebAppDbContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("Database"));
});

// Cấu hình thông báo
builder.Services.AddNotyf(config =>
{
	config.DurationInSeconds = 10;
	config.IsDismissable = true;
	config.Position = NotyfPosition.BottomRight;
});

// Đăng ký repositories
builder.Services.AddAppService(builder.Configuration, builder.Environment);
builder.Services.AddScoped<GenericRepository>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddSignalR();

// Cấu hình đăng nhập
builder.Services.AddAuthentication(AppConst.COOKIES_AUTH)
	.AddCookie(options =>
	{
		options.LoginPath = AppConst.ADMIN_LOGIN_PATH;
		options.ExpireTimeSpan = TimeSpan.FromHours(AppConst.LOGIN_TIMEOUT);
		options.Cookie.HttpOnly = true;
	});

// Cấu hình AutoMapper
var mapperConfig = new MapperConfiguration(config =>
{
	config.AddProfile(new AutoMapperProfile());
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

// Cấu hình thư mục view cho ViewComponent
builder.Services.Configure<RazorViewEngineOptions>(config =>
{
	//path: /Components/{component-name}/Default.cshtml
	config.ViewLocationFormats.Add("/{0}.cshtml");
	config.AreaViewLocationFormats.Add("Areas/Admin/{0}.cshtml");
});

// Khởi tạo thông tin mail
AppMailConfiguration mailConfig = new();
mailConfig.LoadFromConfig(builder.Configuration);
builder.Services.AddSingleton(mailConfig);

// Cấu hình session
builder.Services.AddSession(sessionConf =>
{
	// Dữ liệu session tồn tại trong 2 ngày
	sessionConf.IdleTimeout = TimeSpan.FromDays(2);
	sessionConf.IOTimeout = TimeSpan.FromDays(2);
});

builder.Services.Configure<KestrelServerOptions>(options =>
{
	options.Limits.MaxRequestBodySize = int.MaxValue;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/error/500");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

// Điều hướng khi gặp lỗi
app.UseStatusCodePagesWithReExecute("/error/{0}");

app.UseSession();           // Lệnh này mới sd được mvc session
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCookiePolicy();

app.UseRouting();
app.UseAuthentication();    // Đăng nhập

app.UseAuthorization();

app.MapAreaControllerRoute(
	areaName: "Admin",
	name: "adminLogin",
	pattern: "/Admin/Login",
	defaults: new
	{
		controller = "Account",
		action = "Login",
		area = "Admin"
	}
);
// Đường dẫn cho trang lỗi
app.MapControllerRoute(
	name: "error",
	pattern: "/error/{statusCode}",
	defaults: new
	{
		controller = "Home",
		action = "Error"
	});

// Đường dẫn cho trang Admin
app.MapAreaControllerRoute(
	areaName: "Admin",
	name: "Admin",
	pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();