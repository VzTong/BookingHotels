namespace App.Web.Areas.Admin.ViewModels.Order
{
	public class ListItemOrderDetailVM : ListItemBaseVM
	{
		public string? ImagePath { get; set; }
		public int? OrderId { get; set; }
		public int? RoomId { get; set; }
		public string RoomName { get; set; }
		public decimal RoomPrice { get; set; }
		public int QuantityRoom { get; set; }

		public DateTime CheckInTime_Expected { get; set; }
		public DateTime CheckOutTime_Expected { get; set; }
		public DateTime? CheckInTime { get; set; }
		public DateTime? CheckOutTime { get; set; }
		public int? TimeStay { get; set; }
	}
}