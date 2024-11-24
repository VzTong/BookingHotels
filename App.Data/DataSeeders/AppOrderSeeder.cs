using App.Data.Entities.service;
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
					CreatedDate = now
				},
				new AppOrder
				{
					Id = 2,
					TotalPrice = 126000000,
					QuantityRoom = 1,
					CustomerId = 9,
					CreatedDate = now
				},
				// Orders for rooms with STATUS_BOOKING_NAME
				new AppOrder
				{
					Id = 3,
					QuantityRoom = 1,
					CustomerId = 7,
					CreatedDate = now
				},
				new AppOrder
				{
					Id = 4,
					QuantityRoom = 1,
					CustomerId = 10,
					CreatedDate = now
				},
				new AppOrder
				{
					Id = 5,
					QuantityRoom = 1,
					CustomerId = 17,
					CreatedDate = now
				},
				// Orders for rooms with STATUS_CHECKIN_NAME
				new AppOrder
				{
					Id = 6,
					QuantityRoom = 1,
					CustomerId = 8,
					CreatedDate = now
				},
				new AppOrder
				{
					Id = 7,
					QuantityRoom = 1,
					CustomerId = 14,
					CreatedDate = now
				},
				new AppOrder
				{
					Id = 8,
					QuantityRoom = 1,
					CustomerId = 13,
					CreatedDate = now
				},
				new AppOrder
				{
					Id = 9,
					QuantityRoom = 1,
					CustomerId = 12,
					CreatedDate = now
				},
				new AppOrder
				{
					Id = 10,
					QuantityRoom = 1,
					CustomerId = 11,
					CreatedDate = now
				}
			);
		}
	}
}