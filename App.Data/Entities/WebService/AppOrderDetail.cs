using App.Data.Entities.Base;
using App.Data.Entities.Room;
using App.Data.Entities.User;

namespace App.Data.Entities.service
{
	public class AppOrderDetail : AppEntityBase
    {
		public DateTime CheckInTime_Expected { get; set; }
		public DateTime CheckOutTime_Expected { get; set; }
		public DateTime? CheckInTime { get; set; }
		public DateTime? CheckOutTime { get; set; }
		public decimal? TotalPrice { get; set; }
		public int? TimeStay { get; set; }
        public string? RoomName { get; set; }
		public string? ImagePath { get; set; }
        public int? OrderId { get; set; }
        public int? RoomId { get; set; }

		public AppRoom Room { get; set; }
        public AppOrder Order { get; set; }
        public AppUser Employee { get; set; }
    }
}