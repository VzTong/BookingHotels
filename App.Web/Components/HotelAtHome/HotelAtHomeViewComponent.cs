using App.Data.Entities.Hotel;
using App.Data.Repositories;
using App.Web.ViewModels.Hotel;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace App.Web.Components.HotelAtHome
{
	public class HotelAtHomeViewComponent : ViewComponent
	{
		private readonly GenericRepository _repo;

		public HotelAtHomeViewComponent(GenericRepository repo)
		{
			_repo = repo;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await _repo
				   .GetAll<AppHotel>(x => x.DeletedDate == null && x.IsActive == true)
				   .OrderBy(x => x.DisplayOrder)
				   .Select(x => new HotelVM
				   {
					   Id = x.Id,
					   Name = x.Name,
					   Slug = x.Slug,
					   Description = x.Description,
					   ImgBanner = x.ImgBanner
				   })
				   .ToListAsync();
			return View(data);
		}
	}
}