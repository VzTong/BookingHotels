using App.Data.Entities.Room;
using App.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Areas.Admin.Components.SelectLists
{
	public class SelectListTypeE : ViewComponent
	{
		readonly GenericRepository repository;
		public SelectListTypeE(GenericRepository _db)
		{
			repository = _db;
		}

		public async Task<IViewComponentResult> InvokeAsync(List<int>? selectedValue, string _for, bool allowNull)
		{
			var TypeEList = await repository
				.GetAll<AppEquipmentType>(s => s.DeletedDate == null)
				.OrderByDescending(s => s.CreatedDate)
				.ToListAsync();

			if (TypeEList == null || !TypeEList.Any())
			{
				// Xử lý khi proCate là null hoặc không có phần tử nào
				throw new Exception("Thuộc loại không được để rỗng");
			}

			var listTypeE = new SelectList(TypeEList, "Id", "Name", -1);
			if (selectedValue != null)
			{
				listTypeE = new SelectList(TypeEList, "Id", "Name", selectedValue);
			};
			ViewBag.TypeEList = listTypeE;
			ViewBag.For = _for;
			ViewBag.AllowNull = allowNull;
			return View();
		}
	}
}