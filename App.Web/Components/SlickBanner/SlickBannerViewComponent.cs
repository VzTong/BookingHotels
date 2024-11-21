using App.Data.Entities.Hotel;
using App.Data.Repositories;
using App.Web.Areas.Admin.ViewModels.Hotel;
using App.Web.WebConfig;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Components.SlickBanner
{
	public class SlickBannerViewComponent : ViewComponent
	{
		readonly GenericRepository repository;

		public SlickBannerViewComponent(GenericRepository repo)
		{
			repository = repo;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await repository
				.GetAll<AppHotel>()
				.Where(x => x.IsActive == true && x.DeletedDate == null)
				.OrderByDescending(x => x.DisplayOrder)
				.ThenByDescending(x => x.Id)
				.ProjectTo<HotelListItemVM>(AutoMapperProfile.HotelIndexConf)
				.ToListAsync();
			return View(data);
		}
	}
}