using App.Data.Entities.Hotel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppBranchHotelSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppBranchHotel> builder)
		{
			var now = new DateTime(year: 2021, month: 12, day: 10);

			builder.HasData(
				new AppBranchHotel
				{
					Id = 1,
					Name = "Hà Nội",
					Slug = "ha-noi",
					Address = "Hà Nội, Việt Nam",
					QuantityStaff = 20,
					QuantityRoom = 50,
					CreatedDate = now,
					HotelId = 1 // Khách Sạn Melia Hanoi
				},
				new AppBranchHotel
				{
					Id = 2,
					Name = "TP. Hồ Chí Minh",
					Slug = "tp-ho-chi-minh",
					Address = "TP. Hồ Chí Minh, Việt Nam",
					QuantityStaff = 25,
					QuantityRoom = 80,
					CreatedDate = now,
					HotelId = 2 // Rex Hotel Saigon
				},
				new AppBranchHotel
				{
					Id = 3,
					Name = "Đà Nẵng",
					Slug = "da-nang",
					Address = "Đà Nẵng, Việt Nam",
					QuantityStaff = 15,
					QuantityRoom = 40,
					CreatedDate = now,
					HotelId = 3 // Khách Sạn Đà Nẵng Golden Bay
				},
				new AppBranchHotel
				{
					Id = 4,
					Name = "Nha Trang",
					Slug = "nha-trang",
					Address = "Nha Trang, Việt Nam",
					QuantityStaff = 18,
					QuantityRoom = 60,
					CreatedDate = now,
					HotelId = 4 // Khách Sạn Nha Trang Lodge
				},
				new AppBranchHotel
				{
					Id = 5,
					Name = "Hải Phòng",
					Slug = "hai-phong",
					Address = "Hải Phòng, Việt Nam",
					QuantityStaff = 12,
					QuantityRoom = 30,
					CreatedDate = now,
					HotelId = 5 // Khách Sạn Imperial Hải Phòng
				},
				new AppBranchHotel
				{
					Id = 6,
					Name = "New York",
					Slug = "new-york",
					Address = "New York, USA",
					QuantityStaff = 40,
					QuantityRoom = 100,
					CreatedDate = now,
					HotelId = 6 // Khách Sạn Langham, New York
				},
				new AppBranchHotel
				{
					Id = 7,
					Name = "Tokyo",
					Slug = "tokyo",
					Address = "Tokyo, Nhật Bản",
					QuantityStaff = 35,
					QuantityRoom = 90,
					CreatedDate = now,
					HotelId = 7 // Khách Sạn The Peninsula Tokyo
				},
				new AppBranchHotel
				{
					Id = 8,
					Name = "Cancun",
					Slug = "cancun",
					Address = "Cancun, Mexico",
					QuantityStaff = 30,
					QuantityRoom = 75,
					CreatedDate = now,
					HotelId = 8 // Khách Sạn The Ritz-Carlton, Cancun
				},
				new AppBranchHotel
				{
					Id = 9,
					Name = "Miami",
					Slug = "miami",
					Address = "Miami, USA",
					QuantityStaff = 28,
					QuantityRoom = 60,
					CreatedDate = now,
					HotelId = 9 // Khách Sạn The Biltmore Miami
				},
				new AppBranchHotel
				{
					Id = 10,
					Name = "Paris",
					Slug = "paris",
					Address = "Paris, Pháp",
					QuantityStaff = 45,
					QuantityRoom = 110,
					CreatedDate = now,
					HotelId = 10 // Khách Sạn Shangri-La, Paris
				},
				new AppBranchHotel
				{
					Id = 11,
					Name = "Seoul",
					Slug = "seoul",
					Address = "Seoul, Hàn Quốc",
					QuantityStaff = 50,
					QuantityRoom = 120,
					CreatedDate = now,
					HotelId = 11 // Khách Sạn Grand Hyatt Seoul
				},
				new AppBranchHotel
				{
					Id = 12,
					Name = "Bangkok",
					Slug = "bangkok",
					Address = "Bangkok, Thái Lan",
					QuantityStaff = 32,
					QuantityRoom = 80,
					CreatedDate = now,
					HotelId = 12 // Khách Sạn Four Seasons Bangkok
				},
				new AppBranchHotel
				{
					Id = 13,
					Name = "Tokyo",
					Slug = "tokyo",
					Address = "Tokyo, Nhật Bản",
					QuantityStaff = 38,
					QuantityRoom = 95,
					CreatedDate = now,
					HotelId = 13 // Khách Sạn Hilton Tokyo
				},
				new AppBranchHotel
				{
					Id = 14,
					Name = "Hong Kong",
					Slug = "hong-kong",
					Address = "Hong Kong",
					QuantityStaff = 55,
					QuantityRoom = 130,
					CreatedDate = now,
					HotelId = 14 // Khách Sạn W Hong Kong
				},
				new AppBranchHotel
				{
					Id = 15,
					Name = "Bali",
					Slug = "bali",
					Address = "Bali, Indonesia",
					QuantityStaff = 22,
					QuantityRoom = 70,
					CreatedDate = now,
					HotelId = 15 // Khách Sạn The St. Regis Bali
				},
				new AppBranchHotel
				{
					Id = 16,
					Name = "Bangkok",
					Slug = "bangkok",
					Address = "Bangkok, Thái Lan",
					QuantityStaff = 35,
					QuantityRoom = 85,
					CreatedDate = now,
					HotelId = 16 // Khách Sạn Mandarin Oriental Bangkok
				},
				new AppBranchHotel
				{
					Id = 17,
					Name = "Paris",
					Slug = "paris",
					Address = "Paris, Pháp",
					QuantityStaff = 60,
					QuantityRoom = 140,
					CreatedDate = now,
					HotelId = 17 // Khách Sạn Le Meurice, Paris
				},
				new AppBranchHotel
				{
					Id = 18,
					Name = "Mumbai",
					Slug = "mumbai",
					Address = "Mumbai, Ấn Độ",
					QuantityStaff = 30,
					QuantityRoom = 75,
					CreatedDate = now,
					HotelId = 18 // Khách Sạn The Oberoi, Mumbai
				},
				new AppBranchHotel
				{
					Id = 19,
					Name = "Sydney",
					Slug = "sydney",
					Address = "Sydney, Australia",
					QuantityStaff = 29,
					QuantityRoom = 65,
					CreatedDate = now,
					HotelId = 19 // Khách Sạn Park Hyatt Sydney
				},
				new AppBranchHotel
				{
					Id = 20,
					Name = "Bangkok",
					Slug = "bangkok",
					Address = "Bangkok, Thái Lan",
					QuantityStaff = 33,
					QuantityRoom = 80,
					CreatedDate = now,
					HotelId = 20 // Khách Sạn The Sukhothai Bangkok
				},
				new AppBranchHotel
				{
					Id = 21,
					Name = "Paris",
					Slug = "paris",
					Address = "Paris, Pháp",
					QuantityStaff = 50,
					QuantityRoom = 125,
					CreatedDate = now,
					HotelId = 21 // Khách Sạn Ritz Paris
				},
				new AppBranchHotel
				{
					Id = 22,
					Name = "Mumbai",
					Slug = "mumbai",
					Address = "Mumbai, Ấn Độ",
					QuantityStaff = 27,
					QuantityRoom = 70,
					CreatedDate = now,
					HotelId = 22 // Khách Sạn The Leela, Mumbai
				},
				new AppBranchHotel
				{
					Id = 23,
					Name = "New York",
					Slug = "new-york",
					Address = "New York, USA",
					QuantityStaff = 42,
					QuantityRoom = 110,
					CreatedDate = now,
					HotelId = 23 // Khách Sạn St. Regis New York
				},
				new AppBranchHotel
				{
					Id = 24,
					Name = "Dubai",
					Slug = "dubai",
					Address = "Dubai, UAE",
					QuantityStaff = 50,
					QuantityRoom = 150,
					CreatedDate = now,
					HotelId = 24 // Khách Sạn Jumeirah, Dubai
				},
				new AppBranchHotel
				{
					Id = 25,
					Name = "Italy",
					Slug = "italy",
					Address = "Italy",
					QuantityStaff = 28,
					QuantityRoom = 60,
					CreatedDate = now,
					HotelId = 25 // Khách Sạn Belmond Hotel Caruso
				},
				new AppBranchHotel
				{
					Id = 26,
					Name = "Phuket",
					Slug = "phuket",
					Address = "Phuket, Thái Lan",
					QuantityStaff = 30,
					QuantityRoom = 75,
					CreatedDate = now,
					HotelId = 26 // Khách Sạn Banyan Tree, Phuket
				},
				new AppBranchHotel
				{
					Id = 27,
					Name = "Dubai",
					Slug = "dubai",
					Address = "Dubai, UAE",
					QuantityStaff = 45,
					QuantityRoom = 120,
					CreatedDate = now,
					HotelId = 27 // Khách Sạn The Address, Dubai
				},
				new AppBranchHotel
				{
					Id = 28,
					Name = "Bangkok",
					Slug = "bangkok",
					Address = "Bangkok, Thái Lan",
					QuantityStaff = 35,
					QuantityRoom = 90,
					CreatedDate = now,
					HotelId = 28 // Khách Sạn Shangri-La, Bangkok
				},
				new AppBranchHotel
				{
					Id = 29,
					Name = "Bali",
					Slug = "bali",
					Address = "Bali, Indonesia",
					QuantityStaff = 25,
					QuantityRoom = 65,
					CreatedDate = now,
					HotelId = 29 // Khách Sạn The Oberoi, Bali
				},
				new AppBranchHotel
				{
					Id = 30,
					Name = "Tokyo",
					Slug = "tokyo",
					Address = "Tokyo, Nhật Bản",
					QuantityStaff = 38,
					QuantityRoom = 95,
					CreatedDate = now,
					HotelId = 30 // Khách Sạn Aman Tokyo
				},
				new AppBranchHotel
				{
					Id = 31,
					Name = "Los Angeles",
					Slug = "los-angeles",
					Address = "Los Angeles, USA",
					QuantityStaff = 40,
					QuantityRoom = 110,
					CreatedDate = now
				},
				new AppBranchHotel
				{
					Id = 32,
					Name = "Cairo",
					Slug = "cairo",
					Address = "Cairo, Ai Cập",
					QuantityRoom = 50,
					QuantityStaff = 20,
					CreatedDate = now
				}
			);
		}
	}
}