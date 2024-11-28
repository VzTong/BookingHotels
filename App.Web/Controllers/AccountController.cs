using App.Data.Entities.service;
using App.Data.Entities.User;
using App.Data.Repositories;
using App.Share.Consts;
using App.Share.Extensions;
using App.Web.Areas.Admin.ViewModels.EquipmentType;
using App.Web.Common;
using App.Web.Common.Helpers;
using App.Web.ViewModels.Account;
using App.Web.ViewModels.Cmt;
using App.Web.WebConfig;
using App.Web.WebConfig.Consts;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace App.Web.Controllers
{
	public class AccountController : AppControllerBase
	{
		private readonly INotyfService _notyf;

		public AccountController(IMapper mapper, GenericRepository repo, INotyfService notyf) : base(mapper, repo)
		{
			_notyf = notyf;
		}

		[HttpPost]
		public async Task<IActionResult> Login(LoginClientVM model)
		{
			if (!ModelState.IsValid)
			{
				_notyf.Error("Bạn chưa nhập dữ liệu");
				return RedirectToAction("Index", "Home");
			}
			var user = await _repository.GetOneAsync<AppUser, UserDataForApp>
				(
					where: x => x.Username == model.Username.ToLower(),
					AutoMapperProfile.LoginConf
				);
			if (user == null)
			{
				_notyf.Error("Tên tài khoản không tồn tại");
				return RedirectToAction("Index", "Home");
			}
			if (user.BlockedTo.HasValue && user.BlockedTo.Value >= DateTime.Now)
			{
				_notyf.Error($"Tài khoản của bạn bị khóa đến {user.BlockedTo.Value:dd/MM/yyyy HH:mm}");
				return RedirectToAction("Index", "Home");
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
				_notyf.Error("Tên đăng nhập hoặc mật khẩu không chính xác");
				return RedirectToAction("Index", "Home");
			}
			var claims = new List<Claim> {
							new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
							new Claim(ClaimTypes.Name, user.Username),
							new Claim(ClaimTypes.Email, user.Email),
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
				IsPersistent = true
			};
			await HttpContext.SignInAsync(AppConst.COOKIES_AUTH, principal, authenPropeties);

			CreateDirIfNotExist(model.Username);
			var returnUrl = Request.Query["ReturnUrl"].ToString();
			if (returnUrl.IsNullOrEmpty())
			{
				return RedirectToAction("Index", "Home");
			}
			return Redirect(returnUrl);
		}

		public IActionResult Register() => View();

		[HttpPost]
		public async Task<IActionResult> Register(UserRegisterVM model)
		{
			var returnUrl = Request.Query["ReturnUrl"].ToString();
			var hashResult = HashHMACSHA512(model.Password);
			model.PasswordHash = hashResult.Value;
			model.PasswordSalt = hashResult.Key;
			if (!ModelState.IsValid)
			{
				_notyf.Error("Dữ liệu không hợp lệ vui lòng kiểm tra lại!");
				return RedirectToAction("Index", "Home");
			}
			model.Username = model.Username.ToLower();
			if (await _repository.AnyAsync<AppUser>(x => x.Username == model.Username))
			{
				_notyf.Error("Tên đăng nhập đã tồn tại vui lòng kiểm tra lại!");
				return RedirectToAction("Index", "Home");
			}
			try
			{
				var user = _mapper.Map<AppUser>(model);
				user.AppRoleId = AppConst.ROLE_CUSTOMER_ID;
				await _repository.AddAsync(user);
				_notyf.Success($"Đăng ký tài khoản '{user.Username}' thành công");
				return RedirectToAction("Index", "Home");
			}
			catch (Exception ex)
			{
				if (returnUrl.IsNullOrEmpty())
				{
					return RedirectToAction("Index", "Home");
				}
				return Redirect(returnUrl);
			}
		}

		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync(AppConst.COOKIES_AUTH);
			return RedirectToAction("Index", "Home");
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

		[Route("/thong-tin-ca-nhan")]
		[Authorize]
		public async Task<IActionResult> UserProfile()
		{
			var dataUser = await _repository.FindAsync<AppUser>(CurrentUserId);
			var dataUserVM = _mapper.Map<AppUser, UserProfileClientVM>(dataUser);
			return View(dataUserVM);
		}

		[Authorize]
		[HttpPost("/thong-tin-ca-nhan")]
		public async Task<IActionResult> UserProfile(UserProfileClientVM model, [FromServices] IWebHostEnvironment env)
		{
			if (!ModelState.IsValid)
			{
				_notyf.Error("Dữ liệu không hợp lệ vui lòng kiểm tra lại!");
				return View(model);
			}
			try
			{
				var user = await _repository.FindAsync<AppUser>(CurrentUserId);
				if (model.AvatarPath != null && model.AvatarPath.Length > 0)
				{
					// Xóa ảnh cũ nếu tồn tại
					if (!string.IsNullOrEmpty(user.Avatar))
					{
						var oldImagePath = Path.Combine(env.WebRootPath, user.Avatar.TrimStart('/'));
						//if (System.IO.File.Exists(oldImagePath))
						//{
						//	System.IO.File.Delete(oldImagePath);
						//}
					}

					// Tải lên ảnh mới và cập nhật đường dẫn
					model.Avatar = UploadFile(model.AvatarPath, env.WebRootPath);
				}
				else
				{
					model.Avatar = user.Avatar;
				}

				_mapper.Map<UserProfileClientVM, AppUser>(model, user);
				await _repository.UpdateAsync<AppUser>(user);
				_notyf.Success("Cập nhật thông tin thành công!");
			}
			catch (Exception ex)
			{
				_notyf.Error("Có lỗi trong quá trình xử lý, vui lòng thử lại sau!");
			}
			return RedirectToAction(nameof(UserProfile));
		}

		[HttpPost("doi-mat-khau")]
		public async Task<IActionResult> ChangePassword(ChangePwdVM model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}
			var user = await _repository.FindAsync<AppUser>(CurrentUserId);
			var encryptPassword = this.HashHMACSHA512WithKey(model.Pwd, user.PasswordSalt);
			if (!encryptPassword.SequenceEqual(user.PasswordHash))
			{
				_notyf.Error("Mật khẩu cũ không chính xác");
				return View();
			}

			var hashResult = this.HashHMACSHA512(model.NewPwd);
			user.PasswordHash = hashResult.Value;
			user.PasswordSalt = hashResult.Key;
			await _repository.UpdateAsync<AppUser>(user);

			if (model.LogoutAfterChangePwd)
			{
				_notyf.Success("Đổi mật khẩu thành công");
				return RedirectToAction(nameof(Logout));
			}

			_notyf.Success("Đổi mật khẩu thành công");
			return RedirectToAction(nameof(UserProfile));
		}

		[HttpPost]
		public async Task<IActionResult> SendComment(SendCmtVM model)
		{
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return RedirectToAction(nameof(UserProfile));
			}
			try
			{
				var now = DateTime.Now;
				var user = CurrentUserId;
				var cmt = _mapper.Map<AppComment>(model);
				cmt.CreatedBy = CurrentUserId;
				cmt.CreatedDate = now;

				await _repository.AddAsync(cmt);
				SetSuccessMesg($"Đã đăng bình luận");
				return RedirectToAction(nameof(UserProfile));
			}
			catch (Exception ex)
			{
				return RedirectToAction(nameof(UserProfile));
			}
		}
	}
}