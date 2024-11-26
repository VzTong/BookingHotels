using App.Web.Common;

namespace App.Web.ViewModels.Order
{
	public class CartItemVM
	{
		public int Id { get; set; }
		public string RoomName { get; set; }
		public string Slug { get; set; }
		public decimal Price { get; set; }
		public decimal? DiscountPrice { get; set; }
		public DateTime? DiscountFrom { get; set; }
		public DateTime? DiscountTo { get; set; }
		public bool IsActive { get; set; }
		public string ImagePath { get; set; }
		public string RTypeName { get; set; }
		public string BranchHotelName { get; set; }

		public decimal FinalPrice
		{
			get
			{
				var now = DateTime.Now;
				var price = this.Price;
				var d1 = this.DiscountFrom ?? DateTime.MinValue;
				var d2 = this.DiscountTo ?? DateTime.MaxValue;
				if (this.DiscountPrice.HasValue && now.IsBetween(d1, d2))
				{
					price = this.DiscountPrice.Value;
				}
				return price;
			}
		}
	}
}
