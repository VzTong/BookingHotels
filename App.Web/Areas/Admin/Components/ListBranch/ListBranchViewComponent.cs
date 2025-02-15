﻿using App.Data.Entities.Hotel;
using App.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

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
			int? brandId = GetCurrentUserBranchId();
			var data = await repository
			   .GetAll<AppBranchHotel>(where: r =>
				   (brandId == null || r.Id == brandId) &&
				   (excludeIds == null || !excludeIds.Any() || !excludeIds.Contains(r.Id)))
			   .ToListAsync();

			ViewBag.SelectedId = seletetedId;
			return View(data);
		}

		protected int CurrentUserId { get => Convert.ToInt32(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)); }
		protected string CurrentUsername { get => HttpContext.User.Identity.Name; }

		protected int? GetCurrentUserBranchId()
		{
			var user = repository.DbContext.AppUsers.AsNoTracking().FirstOrDefault(u => u.Id == CurrentUserId);
			return user?.BranchId;
		}
	}
}