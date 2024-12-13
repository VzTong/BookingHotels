namespace App.Web.ViewModels.Room
{
	public class SearchRoomClientVM
	{
		public string? Addr { get; set; }
		public int? Adults { get; set; }

		public DateTime? CheckInTime_Expected { get; set; }
		public DateTime? CheckOutTime_Expected { get; set; }
	}
}