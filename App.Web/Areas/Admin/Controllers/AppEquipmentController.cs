using App.Data.Entities.Room;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Areas.Admin.ViewModels.Equipment;
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
	public class AppEquipmentController : AppControllerBase
	{
		private readonly ILogger<AppBranchHotelController> _logger;
		readonly GenericRepository _repository;

        public AppEquipmentController(GenericRepository repository, ILogger<AppBranchHotelController> logger, IMapper mapper) : base(mapper)
		{
			_logger = logger;
			_repository = repository;
		}

		[AppAuthorize(AuthConst.AppEquipment.VIEW_LIST)]
		public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			var data = (await _repository
				.GetAll<AppEquipment>()
				.ProjectTo<EquipmentListItemVM>(AutoMapperProfile.EquipmentIndexConf)
				.ToPagedListAsync(page, size)).GenRowIndex();
			return View(data);
		}

		[AppAuthorize(AuthConst.AppEquipment.CREATE)]
		[HttpPost]
		public async Task<IActionResult> Create(AddOrUpdateEquipmentVM model, [FromServices] IWebHostEnvironment env)
		{
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (_repository.GetAll<AppEquipment>().Any(s => s.Name.Equals(model.Name)))
			{
				SetErrorMesg("Thiết bị này đã tồn tại !");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			try
			{
				var now = DateTime.Now;
				var user = CurrentUserId;
				var equipment = _mapper.Map<AppEquipment>(model);
				equipment.CreatedBy = CurrentUserId;
				equipment.CreatedDate = now;

				await _repository.AddAsync(equipment);
				SetSuccessMesg($"Thêm thiết bị '{equipment.Name}' thành công");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			catch (Exception ex)
			{
				LogException(ex);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
		}

		[AppAuthorize(AuthConst.AppEquipment.UPDATE)]
		[HttpPost]
		public async Task<IActionResult> Update(AddOrUpdateEquipmentVM model, [FromServices] IWebHostEnvironment env)
		{
			var equipment = await _repository.FindAsync<AppEquipment>((int)model.Id);
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (equipment == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (await _repository.AnyAsync<AppEquipment>(u => u.Name.ToLower().Equals(model.Name.ToLower()) && u.Name != equipment.Name && u.DeletedDate == null))
			{
				SetErrorMesg("Thiết bị này đã tồn tại!");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			try
			{
				// Cập nhật các thuộc tính khác của branch
				_mapper.Map<AddOrUpdateEquipmentVM, AppEquipment>(model, equipment);
				equipment.UpdatedBy = CurrentUserId;
				equipment.UpdatedDate = DateTime.Now;

				await _repository.UpdateAsync(equipment);
				SetSuccessMesg($"Cập nhật thiết bị ◜{equipment.Name}◞ thành công!");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			catch (Exception ex)
			{
				LogException(ex);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
		}

		[AppAuthorize(AuthConst.AppEquipment.DELETE)]
		public async Task<IActionResult> Delete(int id)
		{
			var equipment = await _repository.FindAsync<AppEquipment>(id);
			if (equipment == null)
			{
				SetErrorMesg("Thiết bị này không tồn tại hoặc đã được xóa trước đó");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			// Gỡ khóa ngoại
			equipment.TypeEquipmentId = null;

			await _repository.DeleteAsync(equipment);
			SetSuccessMesg($"Thiết bị '{equipment.Name}' được xóa thành công");
			if (Referer != null)
			{
				return Redirect(Referer);
			}
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}
	}
}