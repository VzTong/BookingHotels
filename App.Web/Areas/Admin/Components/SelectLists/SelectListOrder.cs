using App.Data.Entities.service;
using App.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

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
			int? brandId = GetCurrentUserBranchId();
			var data = await repository.GetAll<AppOrder>
				(m => m.OrderDetails
						.Any(r => r.Room.BranchId == brandId) 
						|| brandId == null
				)
				.Include(m => m.OrderDetails)
				.ThenInclude(r => r.Room)
				.OrderBy(m => m.Id)
				.ToListAsync();
			return View(data);
		}

		protected int CurrentUserId { get => Convert.ToInt32(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)); }
		protected int? GetCurrentUserBranchId()
		{
			var user = repository.DbContext.AppUsers.AsNoTracking().FirstOrDefault(u => u.Id == CurrentUserId);
			return user?.BranchId;
		}
	}
}
