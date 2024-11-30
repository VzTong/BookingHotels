namespace App.Web.ViewModels.Order
{
	public class OrderDataVM
	{
		public string CusName { get; set; }
		public string CusPhone { get; set; }
		public string CusEmail { get; set; }
		public string? CusNote { get; set; }
		public int? CusCitizenId { get; set; }
		public string? CusPassport { get; set; }
		public string? CusPermanent { get; set; }
		public decimal? Total { get; set; }
		public string? Status { get; set; }
		public int QuantityRoom { get; set; }
		public string? ImagePath { get; set; }

		public DateTime CheckInTime_Expected { get; set; }
		public DateTime CheckOutTime_Expected { get; set; }
	}
}
