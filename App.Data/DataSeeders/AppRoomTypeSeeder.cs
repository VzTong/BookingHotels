using App.Data.Entities.Room;
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
					Id = 1,
					RoomTypeName = "Phòng Đơn",
					PeopleStay = 1,
					Description = "Phòng nhỏ cho 1 người, trang bị đầy đủ tiện nghi.",
					BringPet = false,
					CreatedDate = now,
					CreatedBy = 1
				},
				new AppRoomType
				{
					Id = 2,
					RoomTypeName = "Phòng Đôi",
					PeopleStay = 2,
					Description = "Phòng cho 2 người, thích hợp cho cặp đôi hoặc bạn bè.",
					BringPet = false,
					CreatedDate = now,
					CreatedBy = 1
				},
				new AppRoomType
				{
					Id = 3,
					RoomTypeName = "Phòng Gia Đình",
					PeopleStay = 4,
					Description = "Phòng rộng rãi cho gia đình, có giường đôi và giường đơn.",
					BringPet = true,
					CreatedDate = now,
					CreatedBy = 1
				},
				new AppRoomType
				{
					Id = 4,
					RoomTypeName = "Phòng Sang Trọng",
					PeopleStay = 2,
					Description = "Phòng cao cấp với tiện nghi hiện đại và tầm nhìn đẹp.",
					BringPet = false,
					CreatedDate = now,
					CreatedBy = 1
				},
				new AppRoomType
				{
					Id = 5,
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