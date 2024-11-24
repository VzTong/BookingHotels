using App.Data.Entities.News;
using App.Data.Repositories;
using App.Share.Consts;
using App.Share.Extensions;
using App.Web.Areas.Admin.ViewModels.News;
using App.Web.Common;
using App.Web.Common.Mailer;
using App.Web.WebConfig;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace App.Web.Areas.Admin.Controllers
{
	public class AppNewsController : AppControllerBase
	{
		private readonly GenericRepository _repository;
		private readonly AppMailConfiguration _mailConfig;
		private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _env;
		private readonly IHttpContextAccessor _contextAccessor;
		public AppNewsController(IMapper mapper, GenericRepository repository, AppMailConfiguration mailConfig, Microsoft.AspNetCore.Hosting.IHostingEnvironment env, IHttpContextAccessor contextAccessor) : base(mapper, repository)
		{
			_repository = repository;
			_mailConfig = mailConfig;
			_contextAccessor = contextAccessor;
			_env = env;
		}

		[AppAuthorize(AuthConst.AppNews.VIEW_LIST)]
		public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			int? branchId = GetCurrentUserBranchId(); //Truy xuất BranchId của người dùng hiện đang đăng nhập
			ViewBag.BranchId = branchId;

			var query = _repository.GetAll<AppNews>();

			// Nếu BranchId không rỗng, hãy lọc người dùng theo BranchId
			if (branchId.HasValue)
			{
				query = (IOrderedQueryable<AppNews>)query.Where(u => u.Users.BranchId == branchId.Value);
			}

			// Dự án tới ListItemNewsVM và áp dụng phân trang
			var data = (await query
				.ProjectTo<ListItemNewsVM>(AutoMapperProfile.NewsIndexConf)
				.ToPagedListAsync(page, size))
				.GenRowIndex();

			// Trả về view với dữ liệu được phân trang
			return View(data);
		}

		[AppAuthorize(AuthConst.AppNews.CREATE)]
		public IActionResult CreateNews() => View();

		[AppAuthorize(AuthConst.AppNews.CREATE)]
		[HttpPost]
		public async Task<IActionResult> CreateNews(AddOrUpdateNewsVM model, [FromServices] IWebHostEnvironment env)
		{
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return View(model);
			}
			if (await _repository.AnyAsync<AppNews>(u => u.Slug.Equals(StringExtension.Slugify(model.Title)) && u.DeletedDate == null))
			{
				SetErrorMesg("Bài viết này đã tồn tại");
				return View(model);
			}
			try
			{
				var user = CurrentUserId;
				var now = DateTime.Now;

				var news = _mapper.Map<AppNews>(model);
				news.Slug = StringExtension.Slugify(news.Title);
				news.CreatedDate = now;
				news.CreatedBy = user;

				// Upload images if they exist
				if (model.ImgPath != null && model.ImgPath.Length > 0)
				{
					news.CoverImgPath = model.ImgPath != null && model.ImgPath.Length > 0 ? UploadFile(model.ImgPath, env.WebRootPath) : null;
				}
				if (model.ImgThumbnailPath != null && model.ImgThumbnailPath.Length > 0)
				{
					news.CoverImgThumbnailPath = model.ImgThumbnailPath != null && model.ImgThumbnailPath.Length > 0 ? UploadFile(model.ImgThumbnailPath, env.WebRootPath) : null;
				}
				if (model.StampImgPath != null && model.StampImgPath.Length > 0)
				{
					news.StampPath = model.StampImgPath != null && model.StampImgPath.Length > 0 ? UploadFile(model.StampImgPath, env.WebRootPath) : null;
				}

				//if (model.SendAllEmail && User.IsInPermission(AuthConst.AppNews.SENDMAILREGISTER))
				//{
				//	SendMailToSubcribers(news);
				//}

				await _repository.AddAsync(news);
				SetSuccessMesg($"Thêm bài viết '{news.Title}' thành công!");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			catch (Exception ex)
			{
				LogException(ex);
				return View(model);
			}
		}

		[AppAuthorize(AuthConst.AppNews.UPDATE)]
		public async Task<IActionResult> EditNews(int id)
		{
			var post = await _repository.FindAsync<AppNews>(id);
			if (post == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			var postVM = _mapper.Map<AddOrUpdateNewsVM>(post);
			ViewBag.BeforeUrl = Referer;
			return View(postVM);
		}

		[AppAuthorize(AuthConst.AppNews.UPDATE)]
		[HttpPost]
		public async Task<IActionResult> EditNews(AddOrUpdateNewsVM model, [FromServices] IWebHostEnvironment env)
		{
			var post = await _repository.FindAsync<AppNews>(model.Id);

			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return View(model);
			}
			if (post == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}

			if (await _repository.AnyAsync<AppNews>(u => u.Slug.Equals(StringExtension.Slugify(model.Title)) && u.Slug != post.Slug && u.DeletedDate == null))
			{
				SetErrorMesg("Tiêu đề bài viết này đã tồn tại!");
				return View(model);
			}
			try
			{
				// Cập nhật ảnh tin tức
				if (model.ImgPath != null && model.ImgPath.Length > 0)
				{
					// Xóa ảnh cũ nếu tồn tại
					if (!string.IsNullOrEmpty(post.CoverImgPath))
					{
						var oldImagePath = Path.Combine(env.WebRootPath, post.CoverImgPath.TrimStart('/'));
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
					model.CoverImgPath = post.CoverImgPath;
				}

				// Cập nhật ảnh thumbnail
				if (model.ImgThumbnailPath != null && model.ImgThumbnailPath.Length > 0)
				{
					// Xóa ảnh cũ nếu tồn tại
					if (!string.IsNullOrEmpty(post.CoverImgThumbnailPath))
					{
						var oldImagePath = Path.Combine(env.WebRootPath, post.CoverImgThumbnailPath.TrimStart('/'));
						if (System.IO.File.Exists(oldImagePath))
						{
							System.IO.File.Delete(oldImagePath);
						}
					}

					// Tải lên ảnh mới và cập nhật đường dẫn
					model.CoverImgThumbnailPath = UploadFile(model.ImgThumbnailPath, env.WebRootPath);
				}
				else
				{
					model.CoverImgThumbnailPath = post.CoverImgThumbnailPath;
				}

				// Cập nhật ảnh Stamps
				if (model.StampImgPath != null && model.StampImgPath.Length > 0)
				{
					// Xóa ảnh cũ nếu tồn tại
					if (!string.IsNullOrEmpty(post.StampPath))
					{
						var oldImagePath = Path.Combine(env.WebRootPath, post.StampPath.TrimStart('/'));
						if (System.IO.File.Exists(oldImagePath))
						{
							System.IO.File.Delete(oldImagePath);
						}
					}

					// Tải lên ảnh mới và cập nhật đường dẫn
					model.StampPath = UploadFile(model.StampImgPath, env.WebRootPath);
				}
				else
				{
					model.StampPath = post.StampPath;
				}

				_mapper.Map<AddOrUpdateNewsVM, AppNews>(model, post);
				post.UpdatedDate = DateTime.Now;
				post.UpdatedBy = CurrentUserId;
				post.Slug = StringExtension.Slugify(model.Title);
				await _repository.UpdateAsync(post);
				SetSuccessMesg($"Cập nhật bài viết '{post.Title}' thành công!");

				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			catch (Exception ex)
			{
				LogException(ex);
				return View(model);
			}
		}

		[AppAuthorize(AuthConst.AppNews.DELETE)]
		public async Task<IActionResult> Delete(int id)
		{
			var news = await _repository.FindAsync<AppNews>(id);
			if (news == null)
			{
				SetErrorMesg("Tin tức này không tồn tại hoặc đã được xóa trước đó");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			// Gỡ khóa ngoại
			news.CategoryId = null;

			await _repository.DeleteAsync(news);
			SetSuccessMesg($"tin tức '{news.Title}' được xóa thành công");
			if (Referer != null)
			{
				return Redirect(Referer);
			}
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}

		[AppAuthorize(AuthConst.AppNews.PUBLIC)]
		public async Task<IActionResult> PublicNews(int id)
		{
			var news = await _repository.FindAsync<AppNews>(id);
			if (news == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			news.Published = true;
			await _repository.UpdateAsync(news);
			SetSuccessMesg($"Công khai tin tức '{news.Title}' thành công");
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}

		[AppAuthorize(AuthConst.AppNews.UNPUBLIC)]
		public async Task<IActionResult> UnPublicNews(int id)
		{
			var news = await _repository.FindAsync<AppNews>(id);
			if (news == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			news.Published = false;
			await _repository.UpdateAsync(news);
			SetSuccessMesg($"Gỡ tin tức '{news.Title}' thành công");
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}

		public async Task<IActionResult> NewsPin(int id = 0)
		{
			if (id > 0)
			{
				var news = await _repository.FindAsync<AppNews>(id);
				var maxDisplayOrder = _repository
						.DbContext.AppNews.Max(x => x.DisplayOrder);
				news.DisplayOrder = maxDisplayOrder != null ? maxDisplayOrder + 1 : 1;
				await _repository.UpdateAsync(news);
			}
			return Redirect(Referer);
		}

		public async Task<IActionResult> NewsUnPin(int id = 0)
		{
			if (id > 0)
			{
				var news = await _repository.FindAsync<AppNews>(id);
				news.DisplayOrder = null;
				await _repository.UpdateAsync(news);
			}
			return Redirect(Referer);
		}

		//private void SendMailToSubcribers(AppNews news)
		//{
		//	var pathToFile = $"{_env.WebRootPath}" +
		//			$"{Path.DirectorySeparatorChar}" +
		//			$"emailTemplate{Path.DirectorySeparatorChar}InfoNewMessager.html";

		//	var appMailSender = new AppMailSender()
		//	{
		//		Name = "Admin",
		//		Subject = $"Thông tin tới bạn về cửa hàng."
		//	};

		//	using (StreamReader SourceReader = System.IO.File.OpenText(pathToFile))
		//	{
		//		appMailSender.Content = SourceReader.ReadToEnd();
		//	};

		//	var listEmailSubscriber = _repository.GetAll<AppUser>().ToList();
		//	var listMailReciver = new List<AppMailReciver>();
		//	if (listEmailSubscriber.Count() > 0)
		//	{
		//		foreach (var item in listEmailSubscriber)
		//		{
		//			AppMailReciver mailReciver = new AppMailReciver()
		//			{
		//				Name = item.Email,
		//				Email = item.Email
		//			};
		//			listMailReciver.Add(mailReciver);
		//		}
		//	}
		//	var resultEmail = listMailReciver.AsEnumerable();
		//	var path = Url.Action("NewsDetails", "News", new { area = "", slug = news.Slug, id = news.Id });
		//	var doamin = $"{_contextAccessor.HttpContext.Request.Scheme}://{_contextAccessor.HttpContext.Request.Host}{path}";

		//	var contentMessage = Engine.Razor
		//		.RunCompile(appMailSender.Content, "@Model",
		//		null,
		//		new
		//		{
		//			Linknews = doamin,
		//			Signature = _mailConfig.Signature,
		//			Year = DateTime.Now.Year,
		//			CompanyName = appMailSender.Name
		//		});

		//	appMailSender.Content = contentMessage.ToString();
		//	AppMailer.SendToList(appMailSender, resultEmail, _mailConfig);
		//}
	}
}