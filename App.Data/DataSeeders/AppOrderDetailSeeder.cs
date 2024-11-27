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
					CheckInTime_Expected = new DateTime(2024, 10, 1),
					CheckOutTime_Expected = new DateTime(2024, 10, 10),
					CheckInTime = new DateTime(2024, 10, 1),
					CheckOutTime = new DateTime(2024, 10, 10),
					TimeStay = (new DateTime(2024, 10, 10) - new DateTime(2024, 10, 1)).Days,
					CreatedBy = 87,
					CreatedDate = now,
					TotalPrice = CalculatePrice(150000, new DateTime(2024, 10, 1), new DateTime(2024, 10, 10), new DateTime(2024, 10, 10))
				},
				new AppOrderDetail
				{
					Id = 2,
					RoomId = 13,
					RoomName = "T12•502 Luxury",
					OrderId = 2,
					CheckInTime_Expected = new DateTime(2024, 11, 1),
					CheckOutTime_Expected = new DateTime(2024, 11, 10),
					CheckInTime = new DateTime(2024, 11, 1),
					CheckOutTime = new DateTime(2024, 11, 10),
					TimeStay = (new DateTime(2024, 11, 10) - new DateTime(2024, 11, 1)).Days,
					CreatedBy = 79,
					CreatedDate = now,
					TotalPrice = CalculatePrice(140000, new DateTime(2024, 11, 1), new DateTime(2024, 11, 10), new DateTime(2024, 11, 10))
				},
				new AppOrderDetail
				{
					Id = 3,
					RoomId = 2,
					RoomName = "T012•205 Double",
					OrderId = 3,
					CheckInTime_Expected = new DateTime(2024, 10, 15),
					CheckOutTime_Expected = new DateTime(2024, 10, 20),
					CreatedBy = 79,
					CreatedDate = now,
					TotalPrice = CalculatePrice(130000, new DateTime(2024, 10, 15), new DateTime(2024, 10, 20), null)
				},
				new AppOrderDetail
				{
					Id = 4,
					RoomId = 3,
					RoomName = "T02•15 Double",
					OrderId = 4,
					CheckInTime_Expected = new DateTime(2024, 10, 15),
					CheckOutTime_Expected = new DateTime(2024, 10, 20),
					CreatedDate = now,
					TotalPrice = CalculatePrice(120000, new DateTime(2024, 10, 15), new DateTime(2024, 10, 20), null)
				},
				new AppOrderDetail
				{
					Id = 5,
					RoomId = 7,
					RoomName = "T06•202 Family",
					OrderId = 5,
					CheckInTime_Expected = new DateTime(2024, 10, 15),
					CheckOutTime_Expected = new DateTime(2024, 10, 20),
					CreatedBy = 78,
					CreatedDate = now,
					TotalPrice = CalculatePrice(110000, new DateTime(2024, 10, 15), new DateTime(2024, 10, 20), null)
				},
				new AppOrderDetail
				{
					Id = 6,
					RoomId = 8,
					RoomName = "T07•301 VIP",
					OrderId = 6,
					CheckInTime_Expected = new DateTime(2024, 10, 1),
					CheckOutTime_Expected = new DateTime(2024, 10, 10),
					CheckInTime = new DateTime(2024, 10, 1),
					CreatedBy = 78,
					CreatedDate = now,
					TotalPrice = CalculatePrice(100000, new DateTime(2024, 10, 1), new DateTime(2024, 10, 10), null)
				},
				new AppOrderDetail
				{
					Id = 7,
					RoomId = 9,
					RoomName = "T08•302 VIP",
					OrderId = 7,
					CheckInTime_Expected = new DateTime(2024, 10, 1),
					CheckOutTime_Expected = new DateTime(2024, 10, 10),
					CheckInTime = new DateTime(2024, 10, 1),
					CreatedBy = 100,
					CreatedDate = now,
					TotalPrice = CalculatePrice(90000, new DateTime(2024, 10, 1), new DateTime(2024, 10, 10), null)
				},
				new AppOrderDetail
				{
					Id = 8,
					RoomId = 12,
					RoomName = "T11•501 VIP",
					OrderId = 8,
					CheckInTime_Expected = new DateTime(2024, 11, 1),
					CheckOutTime_Expected = new DateTime(2024, 11, 10),
					CheckInTime = new DateTime(2024, 11, 1),
					CreatedBy = 78,
					CreatedDate = now,
					TotalPrice = CalculatePrice(80000, new DateTime(2024, 11, 1), new DateTime(2024, 11, 10), null)
				},
				new AppOrderDetail
				{
					Id = 9,
					RoomId = 10,
					RoomName = "T09•401 Luxury",
					OrderId = 9,
					CheckInTime_Expected = new DateTime(2024, 10, 1),
					CheckOutTime_Expected = new DateTime(2024, 10, 10),
					CheckInTime = new DateTime(2024, 10, 1),
					CreatedBy = 100,
					CreatedDate = now,
					TotalPrice = CalculatePrice(70000, new DateTime(2024, 10, 1), new DateTime(2024, 10, 10), null)
				},
				new AppOrderDetail
				{
					Id = 10,
					RoomId = 11,
					RoomName = "T10•402 Luxury",
					OrderId = 10,
					CheckInTime_Expected = new DateTime(2024, 10, 1),
					CheckOutTime_Expected = new DateTime(2024, 10, 10),
					CheckInTime = new DateTime(2024, 10, 1),
					CreatedBy = 92,
					CreatedDate = now,
					TotalPrice = CalculatePrice(60000, new DateTime(2024, 10, 1), new DateTime(2024, 10, 10), null)
				}
			);
		}

		private static decimal CalculatePrice(decimal roomPrice, DateTime checkInTime, DateTime? checkOutTimeExpected, DateTime? checkOutTime)
		{
			var totalPrice = 0m;

			if (checkInTime != DateTime.MinValue && checkOutTimeExpected.HasValue)
			{
				var totalDays = (checkOutTimeExpected.Value - checkInTime).Days;
				totalPrice = roomPrice * totalDays;

				if (checkOutTime.HasValue)
				{
					var lateCheckoutHours = (checkOutTime.Value - checkOutTimeExpected.Value).TotalHours;

					if (lateCheckoutHours > 0)
					{
						if (lateCheckoutHours <= 3)
						{
							totalPrice += roomPrice * 0.3m;
						}
						else if (lateCheckoutHours <= 6)
						{
							totalPrice += roomPrice * 0.5m;
						}
						else
						{
							totalPrice += roomPrice;
						}
					}
				}
			}

			return totalPrice;
		}
	}
}