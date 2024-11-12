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
			ViewBag.Name = search.Name;
			var data = await GetListBranchAsync(search, page, size);
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
									.ProjectTo<AppBranchHotelListItemVM>(AutoMapperProfile.BranchHotelIndexConf)
									.ToPagedListAsync(page, size)).GenRowIndex();

			// Check if the result is empty and set a flag in ViewBag
			if (!data.Any())
			{
				ViewBag.NoResultsFound = true;
			}

			return data;
		}

		[AppAuthorize(AuthConst.AppBranchHotel.CREATE)]
		[HttpPost]
		public async Task<IActionResult> Create(AddOrUpdateBranchHotelVM model, [FromServices] IWebHostEnvironment env)
		{
			var refererUrl = Request.Headers["Referer"].ToString();
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
				model.IdMap = model.IdMap == null ? $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}" : model.IdMap;

				model.Img = model.ImgPath != null && model.ImgPath.Length > 0 ? UploadFile(model.ImgPath, env.WebRootPath) : null;

				var now = DateTime.Now;
				var user = CurrentUserId;
				var branch = _mapper.Map<AppBranchHotel>(model);
				branch.Slug = StringExtension.Slugify(branch.Name);
				branch.CreatedBy = CurrentUserId;
				branch.CreatedDate = now;

				await _repository.AddAsync(branch);
				SetSuccessMesg($"Thêm chi nhánh '{branch.Name}' thành công");
				return Redirect(refererUrl);

			}
			catch (Exception ex)
			{
				LogException(ex);
				return Redirect(refererUrl);
			}
		}

		[AppAuthorize(AuthConst.AppBranchHotel.UPDATE)]
		[HttpPost]
		public async Task<IActionResult> Update(AddOrUpdateBranchHotelVM model, [FromServices] IWebHostEnvironment env)
		{
            var branch = await _repository.FindAsync<AppBranchHotel>((int)model.Id);
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (branch == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (await _repository.AnyAsync<AppBranchHotel>(u => u.Address.ToLower().Equals(model.Address.ToLower()) && u.Address != branch.Address && u.DeletedDate == null))
			{
				SetErrorMesg("Chi nhánh này đã tồn tại!");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			try
			{
				model.IdMap = model.IdMap == null ? $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}" : model.IdMap;
				if (model.ImgPath != null && model.ImgPath.Length > 0)
				{
					// Xóa ảnh cũ nếu tồn tại
					if (!string.IsNullOrEmpty(branch.Img))
					{
						var oldImagePath = Path.Combine(env.WebRootPath, branch.Img.TrimStart('/'));
						if (System.IO.File.Exists(oldImagePath))
						{
							System.IO.File.Delete(oldImagePath);
						}
					}

					// Tải lên ảnh mới và cập nhật đường dẫn
					model.Img = UploadFile(model.ImgPath, env.WebRootPath);
				}
				else
				{
					model.Img = branch.Img;
				}

				// Cập nhật các thuộc tính khác của branch
				_mapper.Map<AddOrUpdateBranchHotelVM, AppBranchHotel>(model, branch);
				branch.Slug = StringExtension.Slugify(branch.Name);
				branch.UpdatedBy = CurrentUserId;
				branch.UpdatedDate = DateTime.Now;

				await _repository.UpdateAsync(branch);
				SetSuccessMesg($"Cập nhật chi nhánh ◜{branch.Name} - {branch.Address}◞ thành công!");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			catch (Exception ex)
			{
				LogException(ex);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
		}

		[AppAuthorize(AuthConst.AppBranchHotel.DELETE)]
		public async Task<IActionResult> Delete(int id)
		{
			var branch = await _repository.FindAsync<AppBranchHotel>(id);
			if (branch == null)
			{
				SetErrorMesg("Chi nhánh này không tồn tại hoặc đã được xóa trước đó");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			// Gỡ khóa ngoại
			branch.HotelId = null;

			await _repository.DeleteAsync(branch);
			SetSuccessMesg($"Chi nhánh '{branch.Name}' được xóa thành công");
			if (Referer != null)
			{
				return Redirect(Referer);
			}
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}
	}
}