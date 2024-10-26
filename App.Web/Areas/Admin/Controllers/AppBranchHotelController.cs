using App.Data.Entities.Hotel;
using App.Data.Repositories;
using App.Share.Consts;
using App.Share.Extensions;
using App.Web.Areas.Admin.ViewModels.BranchHotel;
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
	public class AppBranchHotelController : AppControllerBase
	{
		private readonly ILogger<AppBranchHotelController> _logger;
		readonly GenericRepository _repository;

		public AppBranchHotelController(GenericRepository repository, ILogger<AppBranchHotelController> logger, IMapper mapper) : base(mapper)
		{
			_logger = logger;
			_repository = repository;
		}

		[AppAuthorize(AuthConst.AppBranchHotel.VIEW_LIST)]
		public async Task<IActionResult> Index(SearchBranchVM search, int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			var data = await GetListBranchAsync(search, page, size);

			ViewBag.Name = search.Name;
			return View(data);
		}
		private async Task<IPagedList<AppBranchHotelListItemVM>> GetListBranchAsync(SearchBranchVM search, int page, int size)
		{
			var defaultWhere = _repository.GetDefaultWhereExpr<AppBranchHotel>(false);
			var query = _repository.DbContext
							.AppBrancheHotels
							.AsNoTracking()
							.Where(defaultWhere);

			if (!search.Name.IsNullOrEmpty())
			{
				query = query.Where(x => x.Name.Contains(search.Name));
			}
			var data = (await query.OrderByDescending(m => m.DisplayOrder)
									.ThenByDescending(m => m.Id)
									.ProjectTo<AppBranchHotelListItemVM>(AutoMapperProfile.BranchHotelConf)
									.ToPagedListAsync(page, size)).GenRowIndex();

			return data;
		}

		[AppAuthorize(AuthConst.AppBranchHotel.CREATE)]
		[HttpPost]
		public async Task<IActionResult> Create(AddOrUpdateBranchHotelVM model, [FromServices] IWebHostEnvironment env)
		{
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (_repository.GetAll<AppBranchHotel>().Any(s => s.Address.Equals(model.Address)))
			{
				SetErrorMesg("Địa chỉ này đã tồn tại !");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			try
			{
				//model.Img = model.Img == null ? $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}" : model.Img;
				model.Img = UploadFile(model.ImgPath, env.WebRootPath);

				var now = DateTime.Now;
				var user = CurrentUserId;
				var branch = _mapper.Map<AppBranchHotel>(model);
				branch.Slug = branch.Name.Slugify();
				branch.CreatedBy = CurrentUserId;
				branch.CreatedDate = now;

				await _repository.AddAsync(branch);
				SetSuccessMesg($"Thêm chi nhánh '{branch.Name}' thành công");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			catch (Exception ex)
			{
				LogException(ex);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
		}
	}
}