using App.Data.Entities.service;
using App.Data.Repositories;
using App.Web.ViewModels.Cmt;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using X.PagedList;

namespace App.Web.Components.CmtAtProfile
{
	public class CmtAtProfileViewComponent : ViewComponent
	{
		private readonly GenericRepository _repo;

		public CmtAtProfileViewComponent(GenericRepository repo)
		{
			_repo = repo;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var user = CurrentUserId;
			var data = await _repo
				   .GetAll<AppComment>(x => x.DeletedDate == null && x.CreatedBy == user)
				   .OrderBy(x => x.DisplayOrder)
				   .Select(x => new CmtVM
				   {
					   Id = x.Id,
					   Description = x.Description,
					   UserName = x.User.FullName,
					   UserAvt = x.User.Avatar,
				   })
				   .ToListAsync();
			return View(data);
		}

		protected int CurrentUserId { get => Convert.ToInt32(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)); }
	}
}