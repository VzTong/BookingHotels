using App.Web.Common;

namespace App.Web.ViewModels.Room
{
	public class RoomVM
	{
		public int Id { get; set; }
		public string RoomName { get; set; }
		public string? Slug { get; set; }
		public decimal Price { get; set; }
		public decimal? DiscountPrice { get; set; }
		public DateTime? DiscountFrom { get; set; }
		public DateTime? DiscountTo { get; set; }
		public string HotelName { get; set; }
		public string BranchDesc { get; set; }
		public string? ImagePath { get; set; }
		public bool IsDiscountProduct
		{
			get
			{
				var now = DateTime.Now;
				var d1 = this.DiscountFrom ?? DateTime.MinValue;
				var d2 = this.DiscountTo ?? DateTime.MaxValue;

				if (this.DiscountPrice.HasValue)
				{
					return now.IsBetween(d1, d2);
				}
				return false;
			}
		}
	}
}