namespace App.Web.Areas.Admin.ViewModels.Order
{
	public class ListItemOrderVM : ListItemBaseVM
	{
		public string CusName { get; set; }
		public string CusPhone { get; set; }
		public string CusEmail { get; set; }
		public string CusNote { get; set; }
		public int QuantityRoom { get; set; }
		public string Status { get; set; }
		public DateTime? CreatedDate { get; set; }
		public Decimal? TotalAmount { get; set; }
		public ICollection<ListItemOrderDetailVM> AppOrderDetails { get; set; }
	}
}