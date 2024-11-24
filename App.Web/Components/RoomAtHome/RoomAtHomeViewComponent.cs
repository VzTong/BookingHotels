using App.Data.Entities.Room;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.ViewModels.Room;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace App.Web.Components.RoomAtHome
{
	public class RoomAtHomeViewComponent : ViewComponent
	{
		private readonly GenericRepository _repo;

		public RoomAtHomeViewComponent(GenericRepository repo)
		{
			_repo = repo;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await _repo
				   .GetAll<AppRoom>(x => x.DeletedDate == null 
										&& x.IsActive == true 
										&& x.Status == DB.RoomStatus.STATUS_CHECKOUT_NAME
										&& x.Status == DB.RoomStatus.STATUS_CANCELED_NAME)
				   .OrderBy(x => x.DisplayOrder)
				   .Select(x => new RoomVM
				   {
					   Id = x.Id,
					   RoomName = x.RoomName,
					   Slug = x.Slug,
					   Price = x.Price,
					   DiscountPrice = x.DiscountPrice,
					   HotelName = x.Branch.Hotel.Name,
					   BranchDesc = x.Branch.Description,
					   ImagePath = x.ImgRooms.FirstOrDefault().ImgSrc
				   })
				   .ToListAsync();
			return View(data);
		}
	}
}