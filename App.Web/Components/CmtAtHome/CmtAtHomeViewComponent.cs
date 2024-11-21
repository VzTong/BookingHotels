using App.Data.Entities.service;
using App.Data.Repositories;
using App.Web.ViewModels.Cmt;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace App.Web.Components.CmtAtHome
{
	public class CmtAtHomeViewComponent : ViewComponent
	{
		private readonly GenericRepository _repo;

		public CmtAtHomeViewComponent(GenericRepository repo)
		{
			_repo = repo;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await _repo
				   .GetAll<AppComment>(x => x.DeletedDate == null)
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
	}
}