using App.Data.Entities.Hotel;
using App.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace App.Web.Areas.Admin.Components.SelectLists
{
	public class SelectListHotel : ViewComponent
	{
		readonly GenericRepository repository;
		public SelectListHotel(GenericRepository _db)
		{
			repository = _db;
		}

        public async Task<IViewComponentResult> InvokeAsync(List<int>? selectedValue, string _for, bool allowNull)
        {
			int? branchId = GetCurrentUserBranchId();

			IQueryable<AppHotel> query = repository.GetAll<AppHotel>();

			if (branchId != null)
			{
				query = query.Where(h => h.BranchHotels.Any(bh => bh.Id == branchId));
			}

			var hotelList = await query
				.OrderByDescending(s => s.CreatedDate)
				.ToListAsync();

			if (hotelList == null || !hotelList.Any())
			{
				// Xử lý khi proCate là null hoặc không có phần tử nào
				throw new Exception("Thuộc khách sạn không được để rỗng");
			}

			var listHotel = new SelectList(hotelList, "Id", "Name", -1);
			if (selectedValue != null)
			{
				listHotel = new SelectList(hotelList, "Id", "Name", selectedValue);
			};
			ViewBag.HotelList = listHotel;
			ViewBag.For = _for;
			ViewBag.AllowNull = allowNull;
			return View();
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