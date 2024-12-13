using App.Data.Entities.Room;
using App.Data.Repositories;
using App.Web.ViewModels.Cmt;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using X.PagedList;

namespace App.Web.Components.AdultsForSearch
{
	public class AdultsForSearchViewComponent : ViewComponent
	{
		private readonly GenericRepository _repo;

		public AdultsForSearchViewComponent(GenericRepository repo)
		{
			_repo = repo;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await _repo
				   .GetAll<AppRoomType>(x => x.DeletedDate == null)
				   .OrderBy(x => x.DisplayOrder)
				   .Distinct()
				   .ToListAsync();
			return View(data);
		}
	}
}