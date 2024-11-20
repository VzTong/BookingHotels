using App.Data.Entities.User;
using App.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace App.Web.Areas.Admin.Components.Permission
{
	public class PermissionViewComponent : ViewComponent
	{
		readonly GenericRepository repository;
		public PermissionViewComponent(GenericRepository _repository)
		{
			repository = _repository;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await repository
							.GetAll<MstPermission>()
							.AsEnumerable()
							.GroupBy(x => x.GroupName)
							.ToListAsync();
			return View(data);
		}
	}
}