using App.Web.Common;

namespace App.Web.Areas.Admin.ViewModels.Order
{
	public class ListItemOrderDetailVM : ListItemBaseVM
	{
		public int? OrderId { get; set; }
		public int? RoomId { get; set; }
		public string RoomName { get; set; }
		public decimal Price { get; set; }
		public decimal? DiscountPrice { get; set; }
		public DateTime? DiscountFrom { get; set; }
		public DateTime? DiscountTo { get; set; }

		public DateTime CheckInTime_Expected { get; set; }
		public DateTime CheckOutTime_Expected { get; set; }
		public DateTime? CheckInTime { get; set; }
		public DateTime? CheckOutTime { get; set; }
		public int? TimeStay { get; set; }
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
				return CalculateTotalPrice(FinalPrice, CheckInTime_Expected, CheckInTime, CheckOutTime_Expected, CheckOutTime);
			}
		}

		private static decimal CalculateTotalPrice(decimal roomPrice, DateTime checkInTimeExpected, DateTime? checkInTime, DateTime checkOutTimeExpected, DateTime? checkOutTimeActual)
		{
			int stayDays = 0;

			if (checkOutTimeActual.HasValue && checkInTime.HasValue)
			{
				stayDays = (checkOutTimeActual.HasValue
							? (checkOutTimeActual.Value - checkInTime.Value).Days
							: (checkOutTimeExpected - checkInTime.Value).Days);
			}

			if (checkInTimeExpected != DateTime.MinValue && checkOutTimeExpected != DateTime.MinValue)
			{
				stayDays = (checkOutTimeExpected - checkInTimeExpected).Days;
			}

			decimal totalPrice = roomPrice * stayDays;

			if (checkOutTimeActual.HasValue && checkOutTimeActual.Value > checkOutTimeExpected)
			{
				TimeSpan lateStay = checkOutTimeActual.Value - checkOutTimeExpected;
				if (lateStay.TotalHours > 6)
				{
					totalPrice += roomPrice;
				}
				else if (lateStay.TotalHours > 3)
				{
					totalPrice += (roomPrice * 0.5m);
				}
				else if (lateStay.TotalHours > 1)
				{
					totalPrice += (roomPrice * 0.3m);
				}
			}

			if (checkOutTimeActual.HasValue && checkOutTimeActual.Value < checkOutTimeExpected)
			{
				TimeSpan earlyStay = checkOutTimeExpected - checkOutTimeActual.Value;
				if (earlyStay.TotalHours > 3)
				{
					totalPrice -= (roomPrice * 0.5m);
				}
				else if (earlyStay.TotalHours > 1)
				{
					totalPrice -= (roomPrice * 0.3m);
				}
			}

			return totalPrice;
		}
	}
}