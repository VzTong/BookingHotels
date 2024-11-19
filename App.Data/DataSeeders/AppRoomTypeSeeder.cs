using App.Data.Entities.Room;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppRoomTypeSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppRoomType> builder)
		{
			var now = new DateTime(year: 2024, month: 10, day: 10);

			builder.HasData(
				new AppRoomType
				{
					Id = DB.AppRoomTypeName.SINGLE_ROOM_ID,
					RoomTypeName = "Phòng Đơn",
					PeopleStay = 1,
					Description = "Phòng nhỏ cho 1 người, trang bị đầy đủ tiện nghi.",
					BringPet = false,
					CreatedDate = now,
					CreatedBy = 1
				},
				new AppRoomType
				{
					Id = DB.AppRoomTypeName.DOUBLE_ROOM_ID,
					RoomTypeName = "Phòng Đôi",
					PeopleStay = 2,
					Description = "Phòng cho 2 người, thích hợp cho cặp đôi hoặc bạn bè.",
					BringPet = false,
					CreatedDate = now,
					CreatedBy = 1
				},
				new AppRoomType
				{
					Id = DB.AppRoomTypeName.FAMILY_ROOM_ID,
					RoomTypeName = "Phòng Gia Đình",
					PeopleStay = 4,
					Description = "Phòng rộng rãi cho gia đình, có giường đôi và giường đơn.",
					BringPet = true,
					CreatedDate = now,
					CreatedBy = 1
				},
				new AppRoomType
				{
					Id = DB.AppRoomTypeName.LUXURY_ROOM_ID,
					RoomTypeName = "Phòng Sang Trọng",
					PeopleStay = 2,
					Description = "Phòng cao cấp với tiện nghi hiện đại và tầm nhìn đẹp.",
					BringPet = false,
					CreatedDate = now,
					CreatedBy = 1
				},
				new AppRoomType
				{
					Id = DB.AppRoomTypeName.VIP_ROOM_ID,
					RoomTypeName = "Phòng VIP",
					PeopleStay = 2,
					Description = "Phòng VIP với các dịch vụ đặc biệt và riêng tư.",
					BringPet = false,
					CreatedDate = now,
					CreatedBy = 1
				}
			);

		}
	}
}