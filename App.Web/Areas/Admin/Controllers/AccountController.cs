using App.Data.Entities.User;
using App.Data.Repositories;
using App.Share.Extensions;
using App.Web.Areas.Admin.ViewModels.Account;
using App.Web.Common.Helpers;
using App.Web.Common.Mailer;
using App.Web.Services.AppUser;
using App.Web.ViewModels.Account;
using App.Web.WebConfig;
using App.Web.WebConfig.Consts;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace App.Web.Areas.Admin.Controllers
{
	public class AccountController : AppControllerBase
	{
		readonly GenericRepository _repository;
		private readonly AppMailConfiguration _mailConfig;
		private readonly IAccountService _accountService;
		private readonly IHostingEnvironment _env;
		private readonly IHttpContextAccessor _accessor;
		private readonly INotyfService _notyf;

		public AccountController(IHttpContextAccessor accessor, IAccountService accountService, IHostingEnvironment env, AppMailConfiguration mailConfig, GenericRepository repository, IMapper mapper, INotyfService notyf) : base(mapper, repository)
		{
			_repository = repository;
			_mailConfig = mailConfig;
			_accountService = accountService;
			_env = env;
			_accessor = accessor;
			_notyf = notyf;
		}

		public IActionResult Login() => User.Identity.IsAuthenticated ? HomePage() : View();

		[HttpPost]
		public async Task<IActionResult> Login(LoginVM model)
		{
			var user = await _repository.GetOneAsync<AppUser, UserDataForApp>
							(
								where: x => x.Username == model.Username.ToLower(),
								AutoMapperProfile.LoginConf
							);
			#region Check user
			// Check user
			if (user == null)
			{
				TempData["Mesg"] = "Tài khoản không tồn tại";
				return View();
			}

			if (user.BlockedTo.HasValue && user.BlockedTo.Value >= DateTime.Now)
			{
				TempData["Mesg"] = $"Tài khoản của bạn bị khóa đến {user.BlockedTo.Value:dd/MM/yyyy HH:mm}";
				return View();
			}
			if (user.BlockedTo.HasValue && user.BlockedTo.Value <= DateTime.Now)
			{
				var data = await _repository.FindAsync<AppUser>(user.Id);
				data.BlockedTo = null;
				data.BlockedBy = null;
				await _repository.UpdateAsync(data);
			}

			var pwdHash = this.HashHMACSHA512WithKey(model.Password, user.PasswordSalt);
			if (!pwdHash.SequenceEqual(user.PasswordHash))
			{
				TempData["Mesg"] = "Tên đăng nhập hoặc mật khẩu không chính xác";
				return View();
			}
			#endregion

			var claims = new List<Claim> {
							new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
							new Claim(ClaimTypes.Name, user.Username),
							new Claim(ClaimTypes.Email, user.Email),
							new Claim(AppClaimTypes.Avatar, user.Avatar ?? "/adminLTE/images/users/avatar-3.jpg"),
							new Claim(AppClaimTypes.FullName, user.FullName),
							new Claim(AppClaimTypes.PhoneNumber, user.PhoneNumber1),
							new Claim(AppClaimTypes.RoleName, user.RoleName),
							new Claim(AppClaimTypes.RoleId, user.AppRoleId.ToString()),
							new Claim(AppClaimTypes.Permissions, user.Permission),
						};
			var claimsIdentity = new ClaimsIdentity(claims, AppConst.COOKIES_AUTH);
			var principal = new ClaimsPrincipal(claimsIdentity);
			var authenPropeties = new AuthenticationProperties()
			{
				ExpiresUtc = DateTime.UtcNow.AddHours(AppConst.LOGIN_TIMEOUT),
				IsPersistent = model.RememberMe
			};

			await HttpContext.SignInAsync(AppConst.COOKIES_AUTH, principal, authenPropeties);

			CreateDirIfNotExist(model.Username);
			var returnUrl = Request.Query["ReturnUrl"].ToString();
			if (returnUrl.IsNullOrEmpty())
			{
				return HomePage();
			}
			return Redirect(returnUrl);
		}

		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync(AppConst.COOKIES_AUTH);
			return Redirect("/admin/account/login");
		}

		[Authorize]
		public async Task<IActionResult> ChangePassword(ChangePassword model)
		{
			var user = await _repository.FindAsync<AppUser>(this.CurrentUserId);
			var encryptPassword = this.HashHMACSHA512WithKey(model.Pwd, user.PasswordSalt);

			#region Check password
			// Check password
			if (!encryptPassword.SequenceEqual(user.PasswordHash))
			{
				SetErrorMesg("Mật khẩu cũ không chính xác");
				return Redirect(Referer);
			}
			
			if (model.ConfirmPassword != model.NewPwd)
			{
				SetErrorMesg("Xác nhận mật khẩu không khớp");
				return Redirect(Referer);
			}

			if (model.NewPwd.Length < VM.UserVM.PWD_MINLEN)
			{
				SetErrorMesg($"Mật khẩu phải có ít nhất {VM.UserVM.PWD_MINLEN} ký tự");
				return Redirect(Referer);
			}
			#endregion

			var hashResult = this.HashHMACSHA512(model.NewPwd);
			user.PasswordHash = hashResult.Value;
			user.PasswordSalt = hashResult.Key;

			await _repository.UpdateAsync<AppUser>(user);

			if (model.LogoutAfterChangePwd)
			{
				return RedirectToAction(nameof(Logout));
			}

			SetSuccessMesg("Đổi mật khẩu thành công");
			return Redirect(Referer);
		}

        [Authorize(AuthenticationSchemes = AppConst.COOKIES_AUTH)]
        public async Task<IActionResult> MyProfile()
        {
            ViewBag.Title = "Tài khoản của tôi";
            var currentUserId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return View(await _accountService.GetUserById(currentUserId));
        }

		public async Task<IActionResult> SettingProfile() => View(await _accountService.GetUserById(Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))));

		[HttpPost]
        [Authorize(AuthenticationSchemes = AppConst.COOKIES_AUTH)]
        public async Task<IActionResult> MyProfile(AcceptUpdateViewModel data)
        {
            try
            {
                data.Id = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
                await _accountService.UpdateUser(data);
                ViewBag.Title = "Tài khoản của tôi";
				SetSuccessMesg("Cập nhật thành công!");
			}
            catch (Exception ex)
            {
				SetErrorMesg("Cập nhật thất bại, thử lại sau ít phút!!");
			}

            return View(await _accountService.GetUserById(Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))));
        }

		[HttpPost]
		public async Task<IActionResult> ChangeAvt(AcceptUpdateViewModel data, [FromServices] IWebHostEnvironment env)
		{
			try
			{
				data.Id = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
				UploadFile(data.AvatarUpload, env.WebRootPath);

				data.Avatar = UploadFile(data.AvatarUpload, env.WebRootPath);
				await _accountService.UpdateUser(data);
				SetSuccessMesg("Cập nhật thành công");
			}

			catch (Exception ex)
			{
				SetErrorMesg("Đã xảy ra lỗi trong quá trình xử lý, vui lòng thử lại sau!!");
			}
			return View(await _accountService.GetUserById(Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))));
		}

		// Tạo thư mục lưu file cho user khi đăng nhập (nếu chưa có)
		private static void CreateDirIfNotExist(string username)
		{
			var userPath = $"{AppConst.SYSTEM_FILE_PATH}{Path.DirectorySeparatorChar}{username}";
			var fullPath = PathHelper.MapPath(userPath);
			if (!Directory.Exists(fullPath))
			{
				Directory.CreateDirectory(fullPath);
				// Thêm file tạm để giữ folder
				var file = PathHelper.MapPath($"{userPath}{Path.DirectorySeparatorChar}{username}.txt");
				System.IO.File.WriteAllText(file, $"Hello {username}!");
			}
		}
	}
}