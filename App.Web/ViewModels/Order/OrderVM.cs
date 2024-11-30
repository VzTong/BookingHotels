namespace App.Web.ViewModels.Order
{
	public class OrderVM
	{
		public int Id { get; set; }
		public Decimal? TotalAmount { get; set; }
		public int QuantityRoom { get; set; }
		public string Status { get; set; }
		public List<OrderDetailVM> AppOrderDetails { get; set; }
	}
}