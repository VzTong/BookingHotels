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


		//[AppAuthorize(AuthConst.AppHotel.CREATE)]
		//[HttpPost]
		//public async Task<IActionResult> Create(AddOrUpdateHotelVM model, [FromServices] IWebHostEnvironment env)
		//{
		//	if (!ModelState.IsValid)
		//	{
		//		SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
		//		return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		//	}
		//	if (_repository.GetAll<AppHotel>().Any(s => s.Name.Equals(model.Name)))
		//	{
		//		SetErrorMesg("Khách sạn này đã tồn tại !");
		//		return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		//	}
		//	try
		//	{
		//		model.Img = model.Img == null ? null : UploadFile(model.ImgPath, env.WebRootPath);

		//		var now = DateTime.Now;
		//		var user = CurrentUserId;
		//		var hotel = _mapper.Map<AppHotel>(model);
		//		hotel.Slug = StringExtension.Slugify(hotel.Name);
		//		hotel.CreatedBy = CurrentUserId;
		//		hotel.CreatedDate = now;

		//		await _repository.AddAsync(hotel);
		//		SetSuccessMesg($"Thêm chi nhánh '{hotel.Name}' thành công");
		//		return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		//	}
		//	catch (Exception ex)
		//	{
		//		LogException(ex);
		//		return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		//	}
		//}


	}
}