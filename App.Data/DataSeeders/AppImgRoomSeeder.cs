using App.Data.Entities.Room;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppImgRoomSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppImgRoom> builder)
		{
			builder.HasData(
				// Photos for RoomId 1
				new AppImgRoom { Id = 1, ImgSrc = "files/ImgRoom/r-9.jpeg", RoomId = 1 },
				new AppImgRoom { Id = 2, ImgSrc = "clientLTE/images/img_2.jpg", RoomId = 1 },
				new AppImgRoom { Id = 3, ImgSrc = "clientLTE/images/img_3.jpg", RoomId = 1 },
				new AppImgRoom { Id = 4, ImgSrc = "clientLTE/images/img_4.jpg", RoomId = 1 },

				// Photos for RoomId 2
				new AppImgRoom { Id = 5, ImgSrc = "files/ImgRoom/r-7.jpeg", RoomId = 2 },
				new AppImgRoom { Id = 6, ImgSrc = "clientLTE/images/img_2.jpg", RoomId = 2 },
				new AppImgRoom { Id = 7, ImgSrc = "clientLTE/images/img_3.jpg", RoomId = 2 },
				new AppImgRoom { Id = 8, ImgSrc = "clientLTE/images/img_4.jpg", RoomId = 2 },

				// Photos for RoomId 3
				new AppImgRoom { Id = 9, ImgSrc = "files/ImgRoom/r-13.jpeg", RoomId = 3 },
				new AppImgRoom { Id = 10, ImgSrc = "clientLTE/images/img_2.jpg", RoomId = 3 },
				new AppImgRoom { Id = 11, ImgSrc = "clientLTE/images/img_3.jpg", RoomId = 3 },
				new AppImgRoom { Id = 12, ImgSrc = "clientLTE/images/img_4.jpg", RoomId = 3 },

				// Photos for RoomId 4
				new AppImgRoom { Id = 13, ImgSrc = "files/ImgRoom/r-2.jpeg", RoomId = 4 },
				new AppImgRoom { Id = 14, ImgSrc = "clientLTE/images/img_2.jpg", RoomId = 4 },
				new AppImgRoom { Id = 15, ImgSrc = "clientLTE/images/img_3.jpg", RoomId = 4 },
				new AppImgRoom { Id = 16, ImgSrc = "clientLTE/images/img_4.jpg", RoomId = 4 },

				// Photos for RoomId 5
				new AppImgRoom { Id = 17, ImgSrc = "files/ImgRoom/r-1.jpeg", RoomId = 5 },
				new AppImgRoom { Id = 18, ImgSrc = "clientLTE/images/img_2.jpg", RoomId = 5 },
				new AppImgRoom { Id = 19, ImgSrc = "clientLTE/images/img_3.jpg", RoomId = 5 },
				new AppImgRoom { Id = 20, ImgSrc = "clientLTE/images/img_4.jpg", RoomId = 5 },

				// Photos for RoomId 6
				new AppImgRoom { Id = 21, ImgSrc = "files/ImgRoom/r-3.jpeg", RoomId = 6 },
				new AppImgRoom { Id = 22, ImgSrc = "clientLTE/images/img_2.jpg", RoomId = 6 },
				new AppImgRoom { Id = 23, ImgSrc = "clientLTE/images/img_3.jpg", RoomId = 6 },
				new AppImgRoom { Id = 24, ImgSrc = "clientLTE/images/img_4.jpg", RoomId = 6 },

				// Photos for RoomId 7
				new AppImgRoom { Id = 25, ImgSrc = "files/ImgRoom/r-4.jpeg", RoomId = 7 },
				new AppImgRoom { Id = 26, ImgSrc = "clientLTE/images/img_2.jpg", RoomId = 7 },
				new AppImgRoom { Id = 27, ImgSrc = "clientLTE/images/img_3.jpg", RoomId = 7 },
				new AppImgRoom { Id = 28, ImgSrc = "clientLTE/images/img_4.jpg", RoomId = 7 },

				// Photos for RoomId 8
				new AppImgRoom { Id = 29, ImgSrc = "files/ImgRoom/r-5.jpeg", RoomId = 8 },
				new AppImgRoom { Id = 30, ImgSrc = "clientLTE/images/img_2.jpg", RoomId = 8 },
				new AppImgRoom { Id = 31, ImgSrc = "clientLTE/images/img_3.jpg", RoomId = 8 },
				new AppImgRoom { Id = 32, ImgSrc = "clientLTE/images/img_4.jpg", RoomId = 8 },

				// Photos for RoomId 9
				new AppImgRoom { Id = 33, ImgSrc = "files/ImgRoom/r-6.jpeg", RoomId = 9 },
				new AppImgRoom { Id = 34, ImgSrc = "clientLTE/images/img_2.jpg", RoomId = 9 },
				new AppImgRoom { Id = 35, ImgSrc = "clientLTE/images/img_3.jpg", RoomId = 9 },
				new AppImgRoom { Id = 36, ImgSrc = "clientLTE/images/img_4.jpg", RoomId = 9 },

				// Photos for RoomId 10
				new AppImgRoom { Id = 37, ImgSrc = "files/ImgRoom/r-8.jpeg", RoomId = 10 },
				new AppImgRoom { Id = 38, ImgSrc = "clientLTE/images/img_2.jpg", RoomId = 10 },
				new AppImgRoom { Id = 39, ImgSrc = "clientLTE/images/img_3.jpg", RoomId = 10 },
				new AppImgRoom { Id = 40, ImgSrc = "clientLTE/images/img_4.jpg", RoomId = 10 },

				// Photos for RoomId 11
				new AppImgRoom { Id = 41, ImgSrc = "files/ImgRoom/r-10.jpeg", RoomId = 11 },
				new AppImgRoom { Id = 42, ImgSrc = "clientLTE/images/img_2.jpg", RoomId = 11 },
				new AppImgRoom { Id = 43, ImgSrc = "clientLTE/images/img_3.jpg", RoomId = 11 },
				new AppImgRoom { Id = 44, ImgSrc = "clientLTE/images/img_4.jpg", RoomId = 11 },

				// Photos for RoomId 12
				new AppImgRoom { Id = 45, ImgSrc = "files/ImgRoom/r-11.jpeg", RoomId = 12 },
				new AppImgRoom { Id = 46, ImgSrc = "clientLTE/images/img_2.jpg", RoomId = 12 },
				new AppImgRoom { Id = 47, ImgSrc = "clientLTE/images/img_3.jpg", RoomId = 12 },
				new AppImgRoom { Id = 48, ImgSrc = "clientLTE/images/img_4.jpg", RoomId = 12 },

				// Photos for RoomId 13
				new AppImgRoom { Id = 49, ImgSrc = "files/ImgRoom/r-12.jpeg", RoomId = 13 },
				new AppImgRoom { Id = 50, ImgSrc = "clientLTE/images/img_2.jpg", RoomId = 13 },
				new AppImgRoom { Id = 51, ImgSrc = "clientLTE/images/img_3.jpg", RoomId = 13 },
				new AppImgRoom { Id = 52, ImgSrc = "clientLTE/images/img_4.jpg", RoomId = 13 }

			);
		}
	}
}