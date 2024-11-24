using App.Data.Entities.Room;
using App.Web.Common;

namespace App.Web.Areas.Admin.ViewModels.Room
{
	public class RoomListItemVM : ListItemBaseVM
	{
		public string RoomName { get; set; }
		public int FloorNumber { get; set; }
		public int RoomNumber { get; set; }
		public string? Slug { get; set; }
		public string Status { get; set; }
		public decimal Price { get; set; }
		public decimal? DiscountPrice { get; set; }
		public DateTime? DiscountFrom { get; set; }
		public DateTime? DiscountTo { get; set; }
		public bool IsActive { get; set; }
		public int? DisplayOrder { get; set; }
		public int? BranchId { get; set; }
		public string BranchName { get; set; }
		public string RoomTypeName { get; set; }
		public string HotelName { get; set; }
		public string? ImagePath { get; set; }

		public List<string> EquipmentName { get; set; }
		public bool IsDiscountProduct
		{
			get
			{
				var now = DateTime.Now;
				var d1 = this.DiscountFrom ?? DateTime.MinValue;
				var d2 = this.DiscountTo ?? DateTime.MaxValue;

				if (this.DiscountPrice.HasValue)
				{
					return now.IsBetween(d1, d2);
				}
				return false;
			}
		}
		public ICollection<AppRoomEquipment> RoomEquipments { get; set; }
	}
}