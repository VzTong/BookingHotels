using App.Data.Entities.Room;
using App.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace App.Web.Areas.Admin.Components.ListRType
{
	public class ListRTypeViewComponent : ViewComponent
	{
		readonly GenericRepository repository;
		public ListRTypeViewComponent(GenericRepository _db)
		{
			repository = _db;
		}
		public async Task<IViewComponentResult> InvokeAsync(int? seletetedId, IEnumerable<int> excludeIds)
		{
			var data = await repository
			   .GetAll<AppRoomType>(where: r => (excludeIds == null || !excludeIds.Any() || !excludeIds.Contains(r.Id)))
			   .ToListAsync();

			ViewBag.SelectedId = seletetedId;
			return View(data);
		}
	}
}