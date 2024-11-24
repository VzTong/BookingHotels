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
				// Order details for rooms with STATUS_CHECKOUT_NAME
				new AppOrderDetail
				{
					Id = 1,
					RoomId = 1,
					OrderId = 1,
					CheckInTime_Expected = new DateTime(2024, 10, 1),
					CheckOutTime_Expected = new DateTime(2024, 10, 10),
					CheckInTime = new DateTime(2024, 10, 1),
					CheckOutTime = new DateTime(2024, 10, 10),
					TimeStay = (new DateTime(2024, 10, 10) - new DateTime(2024, 10, 1)).Days,
					CreatedBy = 87,
					CreatedDate = now
				},
				new AppOrderDetail
				{
					Id = 2,
					RoomId = 13,
					OrderId = 2,
					CheckInTime_Expected = new DateTime(2024, 11, 1),
					CheckOutTime_Expected = new DateTime(2024, 11, 10),
					CheckInTime = new DateTime(2024, 11, 1),
					CheckOutTime = new DateTime(2024, 11, 10),
					TimeStay = (new DateTime(2024, 11, 10) - new DateTime(2024, 11, 1)).Days,
					CreatedBy = 79,
					CreatedDate = now
				},
				new AppOrderDetail
				{
					Id = 3,
					RoomId = 2,
					OrderId = 3,
					CheckInTime_Expected = new DateTime(2024, 10, 15),
					CheckOutTime_Expected = new DateTime(2024, 10, 20),
					CreatedBy = 79,
					CreatedDate = now
				},
				new AppOrderDetail
				{
					Id = 4,
					RoomId = 3,
					OrderId = 4,
					CheckInTime_Expected = new DateTime(2024, 10, 15),
					CheckOutTime_Expected = new DateTime(2024, 10, 20),
					CreatedDate = now
				},
				new AppOrderDetail
				{
					Id = 5,
					RoomId = 7,
					OrderId = 5,
					CheckInTime_Expected = new DateTime(2024, 10, 15),
					CheckOutTime_Expected = new DateTime(2024, 10, 20),
					CreatedBy = 78,
					CreatedDate = now
				},
				// Order details for rooms with STATUS_CHECKIN_NAME
				new AppOrderDetail
				{
					Id = 6,
					RoomId = 8,
					OrderId = 6,
					CheckInTime_Expected = new DateTime(2024, 10, 1),
					CheckOutTime_Expected = new DateTime(2024, 10, 10),
					CheckInTime = new DateTime(2024, 10, 1),
					CreatedBy = 78,
					CreatedDate = now
				},
				new AppOrderDetail
				{
					Id = 7,
					RoomId = 9,
					OrderId = 7,
					CheckInTime_Expected = new DateTime(2024, 10, 1),
					CheckOutTime_Expected = new DateTime(2024, 10, 10),
					CheckInTime = new DateTime(2024, 10, 1),
					CreatedBy = 100,
					CreatedDate = now
				},
				new AppOrderDetail
				{
					Id = 8,
					RoomId = 12,
					OrderId = 8,
					CheckInTime_Expected = new DateTime(2024, 11, 1),
					CheckOutTime_Expected = new DateTime(2024, 11, 10),
					CheckInTime = new DateTime(2024, 11, 1),
					CreatedBy = 78,
					CreatedDate = now
				},
				// Order details for rooms with STATUS_CANCELED_NAME
				new AppOrderDetail
				{
					Id = 9,
					RoomId = 10,
					OrderId = 9,
					CheckInTime_Expected = new DateTime(2024, 10, 1),
					CheckOutTime_Expected = new DateTime(2024, 10, 10),
					CheckInTime = new DateTime(2024, 10, 1),
					CreatedBy = 100,
					CreatedDate = now
				},
				new AppOrderDetail
				{
					Id = 10,
					RoomId = 11,
					OrderId = 10,
					CheckInTime_Expected = new DateTime(2024, 10, 1),
					CheckOutTime_Expected = new DateTime(2024, 10, 10),
					CheckInTime = new DateTime(2024, 10, 1),
					CreatedBy = 92,
					CreatedDate = now
				}
			);
		}
	}
}