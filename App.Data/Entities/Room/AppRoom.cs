using App.Data.Entities.Base;
using App.Data.Entities.Hotel;
using App.Data.Entities.service;

namespace App.Data.Entities.Room
{
    public class AppRoom : AppEntityBase
	{
        public AppRoom()
        {
            ImgRooms = new HashSet<AppImgRoom>();
			OrderDetails = new HashSet<AppOrderDetail>();
			RoomEquipments = new HashSet<AppRoomEquipment>();
        }
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
		public int? BranchId { get; set; }
		public int? RoomTypeId { get; set; }
		
		public AppBranchHotel Branch { get; set; }
		public AppRoomType RoomType { get; set; }
		public ICollection<AppRoomEquipment> RoomEquipments { get; set; }
		public ICollection<AppImgRoom> ImgRooms { get; set; }
		public ICollection<AppOrderDetail> OrderDetails { get; set; }
	}
}