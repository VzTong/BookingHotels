using App.Data.Entities.Base;
using App.Data.Entities.Room;
using App.Data.Entities.User;

namespace App.Data.Entities.Hotel
{
    public class AppBranchHotel : AppEntityBase
	{
        public AppBranchHotel()
        {
            Rooms = new HashSet<AppRoom>();
			Users = new HashSet<AppUser>();
        }
        public string Name { get; set; }
		public string? Slug { get; set; }
		public string? Description { get; set; }
		public string? IdMap { get; set; }
		public string Address { get; set; }
		public int? QuantityStaff { get; set; }
		public int? QuantityFloor { get; set; }
		public int? QuantityRoom { get; set; }
		public string? Img { get; set; }
		public int? HotelId { get; set; }

		public AppHotel Hotel { get; set; }
		public ICollection<AppRoom> Rooms { get; set; }
		public ICollection<AppUser> Users { get; set; }
	}
}