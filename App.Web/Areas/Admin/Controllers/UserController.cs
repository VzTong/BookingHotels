using App.Data.Entities.User;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Areas.Admin.ViewModels.User;
using App.Web.Common;
using App.Web.WebConfig;
using App.Web.WebConfig.Consts;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace App.Web.Areas.Admin.Controllers
{
	public class UserController : AppControllerBase
	{
		readonly GenericRepository _repository;

        public UserController(GenericRepository repository, IMapper mapper) : base(mapper)
		{
			_repository = repository;
		}

		[AppAuthorize(AuthConst.AppUser.VIEW_LIST)]
		public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			// Chú ý dấu ngoặc khi dùng await cùng với GenRowIndex
			var data = (await _repository
				.GetAll<AppUser>(u => u.Username != this.CurrentUsername && u.AppRoleId != AppConst.ROLE_ADMINISTRATOR_ID)
				.ProjectTo<UserListItemVM>(AutoMapperProfile.UserIndexConf)
				.ToPagedListAsync(page, size)).GenRowIndex();
			return View(data);
		}

		[AppAuthorize(AuthConst.AppUser.CREATE)]
		public IActionResult Create() => View();

		[HttpPost]
		[AppAuthorize(AuthConst.AppUser.CREATE)]
		public async Task<IActionResult> Create(UserAddOrEditVM model)
		{
			model.Username = model.Username.ToLower();
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return View(model);
			}

			if (await _repository.AnyAsync<AppUser>(u => u.Username.Equals(model.Username)))
			{
				SetErrorMesg("Tên đăng nhập này đã tồn tại!");
				return View(model);
			}

			try
			{
				var hashResult = HashHMACSHA512(model.Password);
				model.PasswordHash = hashResult.Value;
				model.PasswordSalt = hashResult.Key;
				var user = _mapper.Map<AppUser>(model);
				await _repository.AddAsync(user);
				SetSuccessMesg($"Thêm tài khoản [{user.Username}] thành công!");
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex)
			{
				LogException(ex);
				return View(model);
			}
		}

		[AppAuthorize(AuthConst.AppUser.UPDATE)]
		public async Task<IActionResult> Edit(int id)
		{
			var user = await _repository.FindAsync<AppUser>(id);
			if (user == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index));
			}
			var userEditVM = _mapper.Map<UserAddOrEditVM>(user);
			return View(userEditVM);
		}

		[HttpPost]
		[AppAuthorize(AuthConst.AppUser.UPDATE)]
		public async Task<IActionResult> Edit(UserAddOrEditVM model)
		{
			var user = await _repository.FindAsync<AppUser>((int)model.Id);
			// Không validate các trường dưới dây khi cập nhật
			ModelState.Remove("Username");
			ModelState.Remove("Password");
			ModelState.Remove("ConfirmPwd");

			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return View(model);
			}
			if (user == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index));
			}

			try
			{
				user.FullName = model.FullName;
				user.PhoneNumber1 = model.PhoneNumber1;
				user.PhoneNumber2 = model.PhoneNumber2;
				user.Address = model.Address;
				user.Email = model.Email;
				user.AppRoleId = model.AppRoleId;
				user.BranchId = (int)model.BranchId;
				await _repository.UpdateAsync(user);
				SetSuccessMesg($"Cập nhật tài khoản [{user.Username}] thành công");
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex)
			{
				LogException(ex);
				return View(model);
			}
		}

		[HttpPost]
		[AppAuthorize(AuthConst.AppUser.BLOCK)]
		public async Task<IActionResult> BlockUser(BlockUserVM data)
		{
			try
			{
				var user = await _repository.FindAsync<AppUser>(data.Id);
				user.BlockedBy = CurrentUserId;
				if (data.Permanentblock)
				{
					var date = DateTime.Now;
					var blockTime = date.AddYears(100);
					user.BlockedTo = blockTime;
				}
				else
				{
					user.BlockedTo = data.BlockedTo;
				}
				SetSuccessMesg($"Khóa tài khoản [{user.Username}] thành công!");
				await _repository.UpdateAsync<AppUser>(user);
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				SetErrorMesg($"Có lỗi trong quá trình xử lý!");
				return RedirectToAction(nameof(Index));
			}

		}

		[AppAuthorize(AuthConst.AppUser.UNBLOCK)]
		public async Task<IActionResult> UnBlockUser(int id)
		{
			var user = await _repository.FindAsync<AppUser>(id);
			user.BlockedTo = null;
			user.BlockedBy = null;
			await _repository.UpdateAsync(user);
			SetSuccessMesg($"Mở khóa tài khoản [{user.Username}] thành công!");
			return RedirectToAction(nameof(Index));
		}
	}
}