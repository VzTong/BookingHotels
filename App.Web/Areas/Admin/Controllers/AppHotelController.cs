using App.Data.Entities.Hotel;
using App.Data.Repositories;
using App.Share.Consts;
using App.Share.Extensions;
using App.Web.Areas.Admin.ViewModels.Hotel;
using App.Web.Common;
using App.Web.WebConfig;
using App.Web.WebConfig.Consts;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace App.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(AuthenticationSchemes = AppConst.COOKIES_AUTH)]
	public class AppHotelController : AppControllerBase
	{
		private readonly ILogger<AppHotelController> _logger;
		readonly GenericRepository _repository;

		public AppHotelController(GenericRepository repository, ILogger<AppHotelController> logger, IMapper mapper) : base(mapper)
		{
			_logger = logger;
			_repository = repository;
		}

		[AppAuthorize(AuthConst.AppHotel.VIEW_LIST)]
		public async Task<IActionResult> Index(SearchHotelVM search, int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			ViewBag.Name = search.Name;
			var data = await GetListHotelAsync(search, page, size);
			ViewBag.BranchCounts = data.ToDictionary(h => h.Id, h => h.BranchName.Count);
			return View(data);
		}

		private async Task<IPagedList<AppHotelListItemVM>> GetListHotelAsync(SearchHotelVM search, int page, int size)
		{
			var defaultWhere = _repository.GetDefaultWhereExpr<AppHotel>(false);
			var query = _repository.DbContext
							.AppHotels
							.AsNoTracking()
							.Where(defaultWhere);

			if (!search.Name.IsNullOrEmpty())
			{
				query = query.Where(x => x.Name.Contains(search.Name));
			}
			var data = (await query.OrderByDescending(m => m.DisplayOrder)
									.ThenByDescending(m => m.Id)
									.ProjectTo<AppHotelListItemVM>(AutoMapperProfile.HotelIndexConf)
									.ToPagedListAsync(page, size)).GenRowIndex();

			// Check if the result is empty and set a flag in ViewBag
			if (!data.Any())
			{
				ViewBag.NoResultsFound = true;
			}

			return data;
		}

		[AppAuthorize(AuthConst.AppHotel.CREATE)]
		public IActionResult CreateHotel() => View();

        [HttpPost]
        [AppAuthorize(AuthConst.AppHotel.CREATE)]
        public async Task<IActionResult> CreateHotel(AddOrUpdateHotelVM model, [FromServices] IWebHostEnvironment env)
        {
            if (!ModelState.IsValid)
            {
                SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (_repository.GetAll<AppHotel>().Any(s => s.Name.Equals(model.Name)))
            {
                SetErrorMesg("Khách sạn này đã tồn tại !");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            try
            {
                model.ImgBanner = model.ImgPath != null && model.ImgPath.Length > 0 ? UploadFile(model.ImgPath, env.WebRootPath) : null;

                var now = DateTime.Now;
                var user = CurrentUserId;

                var hotel = _mapper.Map<AppHotel>(model);
                hotel.ImgBanner = model.ImgBanner;
                hotel.Slug = StringExtension.Slugify(hotel.Name);
                hotel.CreatedBy = CurrentUserId;
                hotel.CreatedDate = now;

                await _repository.AddAsync(hotel);

                SetSuccessMesg($"Thêm khách sạn '{hotel.Name}' thành công");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            catch (Exception ex)
            {
                LogException(ex);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
        }
		
		[AppAuthorize(AuthConst.AppHotel.UPDATE)]
		public async Task<IActionResult> EditHotel(int id)
		{
			var hotel = await _repository.FindAsync<AppHotel>(id);
			if (hotel == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index));
			}
			var userEditVM = _mapper.Map<AddOrUpdateHotelVM>(hotel);
			return View(userEditVM);
		}

		[HttpPost]
		[AppAuthorize(AuthConst.AppUser.UPDATE)]
		public async Task<IActionResult> EditHotel(AddOrUpdateHotelVM model, [FromServices] IWebHostEnvironment env)
		{
			var hotel = await _repository.FindAsync<AppHotel>((int)model.Id);
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return View(model);
			}
			if (hotel == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index));
			}

			try
			{
				model.ImgBanner = model.ImgPath != null && model.ImgPath.Length > 0 ? UploadFile(model.ImgPath, env.WebRootPath) : null;

				if (model.ImgPath != null && model.ImgPath.Length > 0)
				{
					// Xóa ảnh cũ nếu tồn tại
					if (!string.IsNullOrEmpty(hotel.ImgBanner))
					{
						var oldImagePath = Path.Combine(env.WebRootPath, hotel.ImgBanner.TrimStart('/'));
						if (System.IO.File.Exists(oldImagePath))
						{
							System.IO.File.Delete(oldImagePath);
						}
					}

					// Tải lên ảnh mới và cập nhật đường dẫn
					model.ImgBanner = UploadFile(model.ImgPath, env.WebRootPath);
				}
				else
				{
					model.ImgBanner = hotel.ImgBanner;
				}

				// Cập nhật các thuộc tính khác của hotel
				_mapper.Map<AddOrUpdateHotelVM, AppHotel>(model, hotel);

				var now = DateTime.Now;
				var user = CurrentUserId;
				hotel.Slug = StringExtension.Slugify(hotel.Name);
				hotel.UpdatedBy = CurrentUserId;
				hotel.UpdatedDate = now;

				await _repository.UpdateAsync(hotel);
				SetSuccessMesg($"Cập nhật khách sạn '{hotel.Name}' thành công");
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex)
			{
				LogException(ex);
				return View(model);
			}
		}

		[AppAuthorize(AuthConst.AppHotel.DELETE)]
		public async Task<IActionResult> Delete(int id)
		{
			var hotel = await _repository.FindAsync<AppHotel>(id);
			if (hotel == null)
			{
				SetErrorMesg("Khách sạn này không tồn tại hoặc đã được xóa trước đó");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			// Delete associated branches
			var branches = await _repository.GetAll<AppBranchHotel>().Where(b => b.HotelId == id).ToListAsync();
			foreach (var branch in branches)
			{
				await _repository.DeleteAsync(branch);
			}

			await _repository.DeleteAsync(hotel);
			SetSuccessMesg($"Khách sạn '{hotel.Name}' được xóa thành công");
			if (Referer != null)
			{
				return Redirect(Referer);
			}
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}

		[AppAuthorize(AuthConst.AppHotel.PUBLIC)]
		public async Task<IActionResult> PublicHotel(int id)
		{
			var hotel = await _repository.FindAsync<AppHotel>(id);
			if (hotel == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			hotel.IsActive = true;
			await _repository.UpdateAsync(hotel);
			SetSuccessMesg($"Công khai khách sạn '{hotel.Name}' thành công");
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}

		[AppAuthorize(AuthConst.AppHotel.UNPUBLIC)]
		public async Task<IActionResult> UnPublicHotel(int id)
		{
			var hotel = await _repository.FindAsync<AppHotel>(id);
			if (hotel == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			hotel.IsActive = false;
			await _repository.UpdateAsync(hotel);
			SetSuccessMesg($"Gỡ khách sạn '{hotel.Name}' thành công");
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}

		public async Task<IActionResult> HotelPin(int id = 0)
		{
			if (id > 0)
			{
				var hotel = await _repository.FindAsync<AppHotel>(id);
				var maxDisplayOrder = _repository
						.DbContext.AppHotels.Max(x => x.DisplayOrder);
				hotel.DisplayOrder = maxDisplayOrder != null ? maxDisplayOrder + 1 : 1;
				await _repository.UpdateAsync(hotel);
			}
			return Redirect(Referer);
		}
		public async Task<IActionResult> HotelUnPin(int id = 0)
		{
			if (id > 0)
			{
				var hotel = await _repository.FindAsync<AppHotel>(id);
				hotel.DisplayOrder = null;
				await _repository.UpdateAsync(hotel);
			}
			return Redirect(Referer);
		}
	}
}