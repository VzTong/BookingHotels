using App.Data.Entities.News;
using App.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Areas.Admin.Components.ListCategoryNews
{
	public class ListCateNewsViewComponent : ViewComponent
	{
		readonly GenericRepository repository;
		public ListCateNewsViewComponent(GenericRepository _db)
		{
			repository = _db;
		}
		public async Task<IViewComponentResult> InvokeAsync(int? seletetedId, IEnumerable<int> excludeIds)
		{
			var data = await repository
					.GetAll<AppNewsCategory>(where: r => excludeIds == null || excludeIds.Any() && !excludeIds.Contains(r.Id))
					.ToListAsync();
			ViewBag.SelectedId = seletetedId;
			return View(data);
		}
	}
}