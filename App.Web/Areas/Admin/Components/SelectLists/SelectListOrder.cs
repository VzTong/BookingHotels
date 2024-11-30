using App.Data.Entities.service;
using App.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Areas.Admin.Components.SelectLists
{
	public class SelectListOrder : ViewComponent
	{
		readonly GenericRepository repository;
		public SelectListOrder(GenericRepository _db)
		{
			repository = _db;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await repository.GetAll<AppOrder>()
				.Include(s => s.OrderDetails)
				.ThenInclude(s => s.Room)
				.OrderBy(x => x.DisplayOrder)
				.ToListAsync();
			return View(data);
		}
	}
}
