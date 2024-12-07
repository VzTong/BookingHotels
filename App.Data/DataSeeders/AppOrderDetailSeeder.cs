using App.Data.Entities.service;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppOrderDetailSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppOrderDetail> builder)
		{
			var now = new DateTime(year: 2024, month: 10, day: 10);

			builder.HasData(
				new AppOrderDetail
				{
					Id = 1,
					RoomId = 1,
					RoomName = "T0145•101 Luxury",
					OrderId = 1,
					CheckInTime_Expected = new DateTime(2023, 10, 1, 14, 0, 0),
					CheckOutTime_Expected = new DateTime(2023, 10, 10, 12, 0, 0),
					CheckInTime = new DateTime(2023, 10, 1, 14, 0, 0),
					CheckOutTime = new DateTime(2023, 10, 10, 12, 0, 0),
					TimeStay = (new DateTime(2023, 10, 10, 12, 0, 0) - new DateTime(2023, 10, 1, 14, 0, 0)).Days,
					CreatedBy = 87,
					CreatedDate = new DateTime(2023, 10, 1),
					UpdatedDate = new DateTime(2023, 10, 10).AddHours(1), // Ensure UpdatedDate is greater than CheckInTime
					TotalPrice = CalculatePrice(12000000, new DateTime(2024, 10, 1, 14, 0, 0), new DateTime(2024, 10, 10, 12, 0, 0), new DateTime(2024, 10, 10, 12, 0, 0))
				},
				new AppOrderDetail
				{
					Id = 2,
					RoomId = 13,
					RoomName = "T12•502 Luxury",
					OrderId = 2,
					CheckInTime_Expected = new DateTime(2024, 11, 1, 14, 0, 0),
					CheckOutTime_Expected = new DateTime(2024, 11, 10, 12, 0, 0),
					CheckInTime = new DateTime(2024, 11, 1, 14, 0, 0),
					CheckOutTime = new DateTime(2024, 11, 10, 12, 0, 0),
					TimeStay = (new DateTime(2024, 11, 10, 12, 0, 0) - new DateTime(2024, 11, 1, 14, 0, 0)).Days,
					CreatedBy = 79,
					CreatedDate = now,
					UpdatedDate = now.AddHours(1), // Ensure UpdatedDate is greater than CheckInTime
					TotalPrice = CalculatePrice(14000000, new DateTime(2024, 11, 1, 14, 0, 0), new DateTime(2024, 11, 10, 12, 0, 0), new DateTime(2024, 11, 10, 12, 0, 0))
				},
				new AppOrderDetail
				{
					Id = 3,
					RoomId = 8,
					RoomName = "T07•301 VIP",
					OrderId = 3,
					CheckInTime_Expected = new DateTime(2024, 11, 25, 6, 0, 0),
					CheckOutTime_Expected = new DateTime(2024, 11, 30, 12, 0, 0),
					CheckInTime = new DateTime(2024, 11, 25, 12, 0, 0),
					CreatedBy = 1,
					CreatedDate = new DateTime(2024, 10, 15),
					TotalPrice = CalculatePrice(20000000, new DateTime(2024, 11, 25, 12, 0, 0), new DateTime(2024, 11, 29, 12, 0, 0), null)
				},
				new AppOrderDetail
				{
					Id = 4,
					RoomId = 9,
					RoomName = "T08•302 VIP",
					OrderId = 3,
					CheckInTime_Expected = new DateTime(2024, 11, 25, 12, 0, 0),
					CheckOutTime_Expected = new DateTime(2024, 11, 29, 14, 0, 0),
					CheckInTime = new DateTime(2024, 11, 25, 12, 0, 0),
					CreatedDate = now,
					CreatedBy = 1,
					TotalPrice = CalculatePrice(20000000, new DateTime(2024, 11, 25, 12, 0, 0), new DateTime(2024, 11, 29, 14, 0, 0), null)
				}
			);
		}

		private static decimal CalculatePrice(decimal roomPrice, DateTime checkInTime, DateTime checkOutTimeExpected, DateTime? checkOutTimeActual)
		{
			int stayDays = (checkOutTimeActual.HasValue
							? (checkOutTimeActual.Value - checkInTime).Days
							: (checkOutTimeExpected - checkInTime).Days);

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

			return totalPrice;
		}
	}
}