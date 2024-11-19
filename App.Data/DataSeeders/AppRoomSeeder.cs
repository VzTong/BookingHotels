using App.Data.Entities.Room;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppRoomSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppRoom> builder)
		{
			var now = new DateTime(year: 2024, month: 10, day: 10);

			builder.HasData(
				new AppRoom
				{
					Id = 1,
					FloorNumber = 145,
					RoomNumber = 101,
					Slug = "t0145-101-luxury",
					Status = DB.RoomStatus.STATUS_CHECKOUT_NAME,
					Price = 15000000.00,
					DiscountPrice = 1200000.00,
					DiscountFrom = new DateTime(2024, 10, 1),
					DiscountTo = new DateTime(2024, 12, 31),
					CreatedDate = now,
					BranchId = 1,
					RoomTypeId = DB.AppRoomTypeName.LUXURY_ROOM_ID,
				},
				new AppRoom
				{
					Id = 2,
					FloorNumber = 12,
					RoomNumber = 205,
					Slug = "t012-205-double",
					Status = DB.RoomStatus.STATUS_BOOKING_NAME,
					Price = 120000.00,
					CreatedDate = now,
					BranchId = 1,
					RoomTypeId = DB.AppRoomTypeName.DOUBLE_ROOM_ID,
				}
			// Add more seed data as needed
			);
		}
	}
}