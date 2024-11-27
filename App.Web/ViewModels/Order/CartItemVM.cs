using App.Web.Common;

public class CartItemVM
{
	public int Id { get; set; }
	public string RoomName { get; set; }
	public string Slug { get; set; }
	public decimal Price { get; set; }
	public string ImagePath { get; set; }
	public decimal? DiscountPrice { get; set; }
	public DateTime? DiscountFrom { get; set; }
	public DateTime? DiscountTo { get; set; }
	public bool IsActive { get; set; }
	public string RTypeName { get; set; }
	public string HotelName { get; set; }
	public string BranchDesc { get; set; }
	public DateTime CheckInTime_Expected { get; set; }
	public DateTime CheckOutTime_Expected { get; set; }

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

	public decimal TotalPrice
	{
		get
		{
			return CalculateTotalPrice(FinalPrice, CheckInTime_Expected, CheckOutTime_Expected);
		}
	}

	private static decimal CalculateTotalPrice(decimal roomPrice, DateTime checkInTimeExpected, DateTime checkOutTimeExpected)
	{
		var totalPrice = 0m;
		var totalDays = 0;

		if (checkInTimeExpected != DateTime.MinValue && checkOutTimeExpected != DateTime.MinValue)
		{
			totalDays = (checkOutTimeExpected - checkInTimeExpected).Days;
			totalPrice = roomPrice * totalDays;
		}

		Console.WriteLine($"Room Price: {roomPrice}, Check-In: {checkInTimeExpected}, Check-Out: {checkOutTimeExpected}, Total Days: {totalDays}, Total Price: {totalPrice}");
		return totalPrice;
	}

}