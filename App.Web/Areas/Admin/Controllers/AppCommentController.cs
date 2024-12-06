using App.Data.Entities.service;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Areas.Admin.ViewModels.Comment;
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
	public class AppCommentController : AppControllerBase
	{
		private readonly ILogger<AppCommentController> _logger;
		readonly GenericRepository _repository;

		public AppCommentController(GenericRepository repository, ILogger<AppCommentController> logger, IMapper mapper) : base(mapper, repository)
		{
			_logger = logger;
			_repository = repository;
		}

		[AppAuthorize(AuthConst.AppComment.VIEW_LIST)]
		public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			var userBranchId = GetCurrentUserBranchId();

			if (userBranchId != null)
			{
				// Return a 403 Forbidden status code
				return StatusCode(403);
			}

			var data = (await _repository
				.GetAll<AppComment>()
				.OrderByDescending(m => m.DisplayOrder)
				.ThenByDescending(m => m.Id)
				.ProjectTo<CmtListItemVM>(AutoMapperProfile.CmtIndexConf)
				.ToPagedListAsync(page, size)).GenRowIndex();
			return View(data);
		}

		[AppAuthorize(AuthConst.AppComment.AD_DELETE)]
		public async Task<IActionResult> Delete(int id)
		{
			var cmt = await _repository.FindAsync<AppComment>(id);
			if (cmt == null)
			{
				SetErrorMesg("Bình luận này không tồn tại hoặc đã được xóa trước đó");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			await _repository.DeleteAsync(cmt);
			SetSuccessMesg($"Bình luận '{cmt.Id}' được xóa thành công");
			if (Referer != null)
			{
				return Redirect(Referer);
			}
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}
	}
}