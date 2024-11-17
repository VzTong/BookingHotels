using App.Data.Entities.Room;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Areas.Admin.ViewModels.EquipmentType;
using App.Web.Common;
using App.Web.WebConfig;
using App.Web.WebConfig.Consts;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace App.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(AuthenticationSchemes = AppConst.COOKIES_AUTH)]
	public class AppETypeController : AppControllerBase
	{
		private readonly ILogger<AppBranchHotelController> _logger;
		readonly GenericRepository _repository;

		public AppETypeController(GenericRepository repository, ILogger<AppBranchHotelController> logger, IMapper mapper) : base(mapper, repository)
		{
			_logger = logger;
			_repository = repository;
		}

		[AppAuthorize(AuthConst.AppEquipmentType.VIEW_LIST)]
		public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			int? branchId = GetCurrentUserBranchId(); //Truy xuất BranchId của người dùng hiện đang đăng nhập
			ViewBag.BranchId = branchId;

			var data = (await _repository
				.GetAll<AppEquipmentType>()
				.OrderByDescending(m => m.DisplayOrder)
				.ThenByDescending(m => m.Id)
				.ProjectTo<ETypeListItemVM>(AutoMapperProfile.ETypeIndexConf)
				.ToPagedListAsync(page, size)).GenRowIndex();
			return View(data);
		}

		[AppAuthorize(AuthConst.AppEquipmentType.CREATE)]
		[HttpPost]
		public async Task<IActionResult> Create(AddOrUpdateETypeVM model, [FromServices] IWebHostEnvironment env)
		{
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (_repository.GetAll<AppEquipmentType>().Any(s => s.Name.Equals(model.Name)))
			{
				SetErrorMesg("Loại trang thiết bị này đã tồn tại !");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			try
			{
				var now = DateTime.Now;
				var user = CurrentUserId;
				var eType = _mapper.Map<AppEquipmentType>(model);
				eType.CreatedBy = CurrentUserId;
				eType.CreatedDate = now;

				await _repository.AddAsync(eType);
				SetSuccessMesg($"Thêm loại trang thiết bị '{eType.Name}' thành công");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			catch (Exception ex)
			{
				LogException(ex);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
		}

		[AppAuthorize(AuthConst.AppEquipmentType.UPDATE)]
		[HttpPost]
		public async Task<IActionResult> Update(AddOrUpdateETypeVM model, [FromServices] IWebHostEnvironment env)
		{
			var eType = await _repository.FindAsync<AppEquipmentType>((int)model.Id);
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (eType == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (await _repository.AnyAsync<AppEquipmentType>(u => u.Name.ToLower().Equals(model.Name.ToLower()) && u.Name != eType.Name && u.DeletedDate == null))
			{
				SetErrorMesg("Loại trang thiết bị này đã tồn tại!");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			try
			{
				// Cập nhật các thuộc tính khác của eType
				_mapper.Map<AddOrUpdateETypeVM, AppEquipmentType>(model, eType);
				eType.UpdatedBy = CurrentUserId;
				eType.UpdatedDate = DateTime.Now;

				await _repository.UpdateAsync(eType);
				SetSuccessMesg($"Cập nhật loại trang thiết bị ◜{eType.Name}◞ thành công!");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			catch (Exception ex)
			{
				LogException(ex);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
		}

		[AppAuthorize(AuthConst.AppEquipmentType.DELETE)]
		public async Task<IActionResult> Delete(int id)
		{
			var eType = await _repository.FindAsync<AppEquipmentType>(id);
			if (eType == null)
			{
				SetErrorMesg("Loại trang thiết bị này không tồn tại hoặc đã được xóa trước đó");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}

			await _repository.DeleteAsync(eType);
			SetSuccessMesg($"Loại trang thiết bị '{eType.Name}' được xóa thành công");
			if (Referer != null)
			{
				return Redirect(Referer);
			}
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}
	}
}