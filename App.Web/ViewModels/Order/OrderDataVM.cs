namespace App.Web.ViewModels.Order
{
	public class OrderDataVM
	{
		public string CusName { get; set; }
		public string CusPhone { get; set; }
		public string CusEmail { get; set; }
		public string DeliveryAddress { get; set; }
		public string CusNote { get; set; }
		public decimal Total { get; set; }
		public int StatusId { get; set; }
	}
}
