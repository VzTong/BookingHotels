using App.Data.Entities.Room;
using App.Web.ViewModels.Room;

namespace App.Web.ViewModels.Order
{
	public class OrderDetailVM
	{
		public int Id { get; set; }
		public int? OrderId { get; set; }
		public string RoomName { get; set; }
		public string RoomStatus { get; set; }
		public decimal? DiscountPrice { get; set; }
		public DateTime? DiscountFrom { get; set; }
		public DateTime? DiscountTo { get; set; }

		public DateTime CheckInTime_Expected { get; set; }
		public DateTime CheckOutTime_Expected { get; set; }
		public DateTime? CheckInTime { get; set; }
		public DateTime? CheckOutTime { get; set; }
		public int? TimeStay { get; set; }
		public decimal? TotalPrice { get; set; }

		public int? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public DateTime? DeletedDate { get; set; }
	}
}