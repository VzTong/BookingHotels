using App.Data.Entities.News;
using App.Data.Repositories;
using App.Share.Consts;
using App.Share.Extensions;
using App.Web.Areas.Admin.ViewModels.CategoryNews;
using App.Web.Common;
using App.Web.WebConfig;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace App.Web.Areas.Admin.Controllers
{
	public class AppNewsCategoryController : AppControllerBase
	{
		readonly GenericRepository _repository;

		public AppNewsCategoryController(GenericRepository repository, IMapper mapper) : base(mapper, repository)
		{
			_repository = repository;
		}

		[AppAuthorize()]
		public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			int? branchId = GetCurrentUserBranchId(); //Truy xuất BranchId của người dùng hiện đang đăng nhập
			ViewBag.BranchId = branchId;

			var data = (await _repository
			.GetAll<AppNewsCategory>()
			.ProjectTo<ListItemCategoryNewsVM>(AutoMapperProfile.CategoryNewsIndexConf)
			.ToPagedListAsync(page, size))
			.GenRowIndex();
			return View(data);
		}

		[AppAuthorize(AuthConst.AppCategoryNews.CREATE)]
		public IActionResult CreateCateNews() => View();

		[AppAuthorize(AuthConst.AppCategoryNews.CREATE)]
		[HttpPost]
		public async Task<IActionResult> CreateCateNews(AddOrUpdateCategoryNewsVM model, [FromServices] IWebHostEnvironment env)
		{
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return View(model);
			}

			if (await _repository.AnyAsync<AppNewsCategory>(u => u.Title.Equals(model.Title)))
			{
				SetErrorMesg("Thể loại này đã tồn tại");
				return View(model);
			}
			try
			{
				var now = DateTime.Now;

				var category = _mapper.Map<AppNewsCategory>(model);
				if (model.ImgPath != null && model.ImgPath.Length > 0)
				{
					category.CoverImgPath = model.ImgPath != null && model.ImgPath.Length > 0 ? UploadFile(model.ImgPath, env.WebRootPath) : null;
				}
				category.Slug = StringExtension.Slugify(category.Title);
				category.CreatedDate = now;
				category.CreatedBy = CurrentUserId;
				await _repository.AddAsync(category);
				SetSuccessMesg($"Thêm thể loại '{category.Title}' thành công");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			catch (Exception ex)
			{
				LogException(ex);
				return View(model);
			}
		}

		[HttpGet]
		[AppAuthorize(AuthConst.AppCategoryNews.UPDATE)]
		public async Task<IActionResult> EditCateNews(int id)
		{
			var cate = await _repository.FindAsync<AppNewsCategory>(id);
			if (cate == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}

			var categoryVM = _mapper.Map<AddOrUpdateCategoryNewsVM>(cate);

			return View(categoryVM);
		}

		[AppAuthorize(AuthConst.AppCategoryNews.UPDATE)]
		[HttpPost]
		public async Task<IActionResult> EditCateNews(AddOrUpdateCategoryNewsVM model, [FromServices] IWebHostEnvironment env)
		{
			var category = await _repository.FindAsync<AppNewsCategory>(model.Id);

			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return View(model);
			}
			if (category == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (await _repository.AnyAsync<AppNewsCategory>(u => u.Title.Equals(model.Title) && u.Title != category.Title))
			{
				SetErrorMesg("Thể loại này đã tồn tại !");
				return View(model);
			}
			try
			{
				if (model.ImgPath != null && model.ImgPath.Length > 0)
				{
					// Xóa ảnh cũ nếu tồn tại
					if (!string.IsNullOrEmpty(category.CoverImgPath))
					{
						var oldImagePath = Path.Combine(env.WebRootPath, category.CoverImgPath.TrimStart('/'));
						if (System.IO.File.Exists(oldImagePath))
						{
							System.IO.File.Delete(oldImagePath);
						}
					}

					// Tải lên ảnh mới và cập nhật đường dẫn
					model.CoverImgPath = UploadFile(model.ImgPath, env.WebRootPath);
				}
				else
				{
					model.CoverImgPath = category.CoverImgPath;
				}

				_mapper.Map<AddOrUpdateCategoryNewsVM, AppNewsCategory>(model, category);
				category.UpdatedDate = DateTime.Now;
				category.UpdatedBy = CurrentUserId;
				category.Slug = StringExtension.Slugify(model.Title);
				await _repository.UpdateAsync(category);
				SetSuccessMesg($"Cập nhật thể loại [{category.Title}] thành công");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			catch (Exception ex)
			{
				LogException(ex);
				return View(model);
			}
		}

		[AppAuthorize(AuthConst.AppCategoryNews.DELETE)]
		public async Task<IActionResult> Delete(int id)
		{
			var category = await _repository.FindAsync<AppNewsCategory>(id);
			if (category == null)
			{
				SetErrorMesg("Thể loại không tồn tại hoặc đã được xóa trước đó");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (await _repository.AnyAsync<AppNews>(s => s.CategoryId.Equals(category.Id)))
			{
				SetErrorMesg("Thể loại có tồn tại bài viết nên không thể xóa !");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			await _repository.DeleteAsync(category);
			SetSuccessMesg($"Thể loại '{category.Title}' được xóa thành công");
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}
	}
}