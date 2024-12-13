using App.Data.Entities.Room;
using App.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace App.Web.Areas.Admin.Components.SelectLists
{
	public class SelectListEquipment : ViewComponent
	{
		readonly GenericRepository repository;
		public SelectListEquipment(GenericRepository _db)
		{
			repository = _db;
		}

		public async Task<IViewComponentResult> InvokeAsync(List<int>? selectedValue, string _for, bool allowNull)
		{
			var equipment = await repository
				.GetAll<AppEquipment>(s => s.DeletedDate == null)
				.OrderByDescending(s => s.CreatedDate)
				.ToListAsync();

			if (equipment == null || !equipment.Any())
			{
				// Xử lý khi equipment là null hoặc không có phần tử nào
				throw new Exception("Equipment là null hoặc không có phần tử nào");
			}

			MultiSelectList listE;

			if (selectedValue == null)
			{
				listE = new MultiSelectList(equipment, "Id", "Name");
			}
			else
			{
				//var selectedValues = new int[] { selectedValue. };
				listE = new MultiSelectList(equipment, "Id", "Name", selectedValue);
			}

			ViewBag.RoomE = listE;
			ViewBag.For = _for;
			ViewBag.AllowNull = allowNull;
			return View();
		}
	}
}