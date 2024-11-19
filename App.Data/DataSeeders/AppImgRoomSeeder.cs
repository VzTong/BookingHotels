using App.Data.Entities.Room;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppImgRoomSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppImgRoom> builder)
		{
			builder.HasData(
				new AppImgRoom
				{
					Id = 1,
					ImgSrc = "/clientLTE/images/img_1.jpg",
					RoomId = 1 // Assuming RoomId 1 corresponds to the first room in AppRoomSeeder
				},
				new AppImgRoom
				{
					Id = 2,
					ImgSrc = "/clientLTE/images/img_2.jpg",
					RoomId = 1
				},
				new AppImgRoom
				{
					Id = 3,
					ImgSrc = "/clientLTE/images/img_3.jpg",
					RoomId = 1
				},
				new AppImgRoom
				{
					Id = 4,
					ImgSrc = "/clientLTE/images/img_4.jpg",
					RoomId = 1
				},
				new AppImgRoom
				{
					Id = 5,
					ImgSrc = "/clientLTE/images/img_1.jpg",
					RoomId = 2 // Assuming RoomId 2 corresponds to the second room in AppRoomSeeder
				},
				new AppImgRoom
				{
					Id = 6,
					ImgSrc = "/clientLTE/images/img_2.jpg",
					RoomId = 2
				},
				new AppImgRoom
				{
					Id = 7,
					ImgSrc = "/clientLTE/images/img_3.jpg",
					RoomId = 2
				},
				new AppImgRoom
				{
					Id = 8,
					ImgSrc = "/clientLTE/images/img_4.jpg",
					RoomId = 2
				}
			// Add more seed data as needed
			);
		}
	}
}