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
					TotalPrice = 96000000,
					QuantityRoom = 1,
					CustomerId = 3,
					CreatedDate = new DateTime(2023, 10, 1),
					CusName = "John Smith",
					CusPhone = "+12025550123",
					CusEmail = "johnsmith1992@gmail.com",
					CusPassport = "123456789",
					CusNote = "No special requests",
					Status = DB.OrderStatus.STATUS_DONE_NAME
				},
				new AppOrder
				{
					Id = 2,
					TotalPrice = 112000000,
					QuantityRoom = 1,
					CustomerId = 9,
					CreatedDate = now,
					CusName = "Nguyễn Văn Khánh",
					CusPhone = "+84911234567",
					CusEmail = "user2@gmail.com",
					CusCitizenId = 123456789,
					CusNote = "Late check-in",
					Status = DB.OrderStatus.STATUS_DONE_NAME
				},
				new AppOrder
				{
					Id = 3,
					QuantityRoom = 2,
					CustomerId = 11,
					CreatedDate = new DateTime(2024, 10, 15),
					CusName = "Trần Thị Hòa",
					CusPhone = "+84931234567",
					CusEmail = "user4@gmail.com",
					CusCitizenId = 345678901,
					CusNote = "Early check-in",
					Status = DB.OrderStatus.STATUS_PROCESSING_NAME
				}
			);
		}
	}
}