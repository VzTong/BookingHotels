using App.Data.Entities.Hotel;
using App.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Areas.Admin.Components.ListBranchHotel
{
	public class ListBranchViewComponent : ViewComponent
	{
		readonly GenericRepository repository;
		public ListBranchViewComponent(GenericRepository _db)
		{
			repository = _db;
		}
		public async Task<IViewComponentResult> InvokeAsync(int? seletetedId, IEnumerable<int> excludeIds)
		{
			var data = await repository
					.GetAll<AppBranchHotel>(where: r => excludeIds == null || excludeIds.Any() && !excludeIds.Contains(r.Id))
					.ToListAsync();
			ViewBag.SelectedId = seletetedId;
			return View(data);
		}
	}
}