using App.Data.Entities.service;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppOrderSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppOrder> builder)
		{
			var now = new DateTime(year: 2024, month: 10, day: 10);

			builder.HasData(
				// Orders for rooms with STATUS_CHECKOUT_NAME
				new AppOrder
				{
					Id = 1,
					TotalPrice = 135000000,
					QuantityRoom = 1,
					CustomerId = 3,
					CreatedDate = now,
					CusName = "John Smith",
					CusPhone = "+12025550123",
					CusEmail = "johnsmith1992@gmail.com",
					CusNote = "No special requests",
					Status = DB.OrderStatus.STATUS_DONE_NAME
				},
				new AppOrder
				{
					Id = 2,
					TotalPrice = 126000000,
					QuantityRoom = 1,
					CustomerId = 9,
					CreatedDate = now,
					CusName = "Nguyễn Văn Khánh",
					CusPhone = "+84911234567",
					CusEmail = "user2@gmail.com",
					CusNote = "Late check-in",
					Status = DB.OrderStatus.STATUS_DONE_NAME
				},
				// Orders for rooms with STATUS_BOOKING_NAME
				new AppOrder
				{
					Id = 3,
					QuantityRoom = 1,
					CustomerId = 11,
					CreatedDate = now,
					CusName = "Trần Thị Hòa",
					CusPhone = "+84931234567",
					CusEmail = "user4@gmail.com",
					CusNote = "Early check-in",
					Status = DB.OrderStatus.STATUS_PROCESSING_NAME
				},
				new AppOrder
				{
					Id = 4,
					QuantityRoom = 1,
					CustomerId = 10,
					CreatedDate = now,
					CusName = "Nguyễn Thị Hồng",
					CusPhone = "+84921234567",
					CusEmail = "user3@gmail.com",
					CusNote = "No special requests",
					Status = DB.OrderStatus.STATUS_PROCESSING_NAME
				},
				new AppOrder
				{
					Id = 5,
					QuantityRoom = 1,
					CustomerId = 17,
					CreatedDate = now,
					CusName = "David Wilson",
					CusPhone = "+12025550127",
					CusEmail = "foreign_user5@gmail.com",
					CusNote = "Late check-out",
					Status = DB.OrderStatus.STATUS_PROCESSING_NAME
				},
				// Orders for rooms with STATUS_CHECKIN_NAME
				new AppOrder
				{
					Id = 6,
					QuantityRoom = 1,
					CustomerId = 15,
					CreatedDate = now,
					CusName = "Michael Johnson",
					CusPhone = "+12025550125",
					CusEmail = "user8@gmail.com",
					CusNote = "No special requests",
					Status = DB.OrderStatus.STATUS_PROCESSING_NAME
				},
				new AppOrder
				{
					Id = 7,
					QuantityRoom = 1,
					CustomerId = 14,
					CreatedDate = now,
					CusName = "Jane Smith",
					CusPhone = "+12025550124",
					CusEmail = "user7@gmail.com",
					CusNote = "Early check-out",
					Status = DB.OrderStatus.STATUS_PROCESSING_NAME
				},
				new AppOrder
				{
					Id = 8,
					QuantityRoom = 1,
					CustomerId = 13,
					CreatedDate = now,
					CusName = "John Doe",
					CusPhone = "+12025550123",
					CusEmail = "user6@gmail.com",
					CusNote = "No special requests",
					Status = DB.OrderStatus.STATUS_PROCESSING_NAME
				},
				new AppOrder
				{
					Id = 9,
					QuantityRoom = 1,
					CustomerId = 12,
					CreatedDate = now,
					CusName = "Danh Thành Đạt",
					CusPhone = "+84941234567",
					CusEmail = "user5@gmail.com",
					CusNote = "Late check-in",
					Status = DB.OrderStatus.STATUS_PROCESSING_NAME
				},
				new AppOrder
				{
					Id = 10,
					QuantityRoom = 1,
					CustomerId = 16,
					CreatedDate = now,
					CusName = "Emily Davis",
					CusPhone = "+12025550126",
					CusEmail = "user9@gmail.com",
					CusNote = "No special requests",
					Status = DB.OrderStatus.STATUS_PROCESSING_NAME
				}
			);
		}
	}
}