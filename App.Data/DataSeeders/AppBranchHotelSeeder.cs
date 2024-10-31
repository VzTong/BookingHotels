using App.Data.Entities.Hotel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppBranchHotelSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppBranchHotel> builder)
		{
			var now = new DateTime(year: 2024, month: 10, day: 10);

			builder.HasData(
				new AppBranchHotel
				{
					Id = 1,
					Name = "Hà Nội",
					Slug = "ha-noi",
					Address = "123 Phố Lý Thái Tổ, Quận Hoàn Kiếm, Hà Nội, Việt Nam",
					QuantityStaff = 20,
					QuantityRoom = 50,
					CreatedDate = now,
					HotelId = 1, // Khách Sạn Melia Hà Nội
					Description = "Chi nhánh của Melia Hà Nội tại Hà Nội"
				},
				new AppBranchHotel
				{
					Id = 2,
					Name = "TP. Hồ Chí Minh",
					Slug = "tp-ho-chi-minh",
					Address = "456 Đường Nguyễn Huệ, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh, Việt Nam",
					QuantityStaff = 25,
					QuantityRoom = 80,
					CreatedDate = now,
					HotelId = 2, // Rex Hotel Sài Gòn
					Description = "Chi nhánh của Rex Hotel Sài Gòn tại TP. Hồ Chí Minh"
				},
				new AppBranchHotel
				{
					Id = 3,
					Name = "Đà Nẵng",
					Slug = "da-nang",
					Address = "789 Đường Bạch Đằng, Phường Hải Châu, Đà Nẵng, Việt Nam",
					QuantityStaff = 15,
					QuantityRoom = 40,
					CreatedDate = now,
					HotelId = 3, // Khách Sạn Đà Nẵng Golden Bay
					Description = "Chi nhánh của Đà Nẵng Golden Bay tại Đà Nẵng"
				},
				new AppBranchHotel
				{
					Id = 4,
					Name = "Nha Trang",
					Slug = "nha-trang",
					Address = "101 Đường Trần Phú, Thành phố Nha Trang, Khánh Hòa, Việt Nam",
					QuantityStaff = 18,
					QuantityRoom = 60,
					CreatedDate = now,
					HotelId = 4, // Khách Sạn Nha Trang Lodge
					Description = "Chi nhánh của Nha Trang Lodge tại Nha Trang"
				},
				new AppBranchHotel
				{
					Id = 5,
					Name = "Hải Phòng",
					Slug = "hai-phong",
					Address = "202 Đường Lê Đại Hành, Quận Hồng Bàng, Hải Phòng, Việt Nam",
					QuantityStaff = 12,
					QuantityRoom = 30,
					CreatedDate = now,
					HotelId = 5, // Khách Sạn Imperial Hải Phòng
					Description = "Chi nhánh của Imperial Hải Phòng tại Hải Phòng"
				},
				new AppBranchHotel
				{
					Id = 6,
					Name = "New York",
					Slug = "new-york",
					Address = "600 Đường 5th Ave, New York, NY 10020, USA",
					QuantityStaff = 40,
					QuantityRoom = 100,
					CreatedDate = now,
					HotelId = 6, // Khách Sạn Langham, New York
					Description = "Chi nhánh của Langham Hotel tại New York"
				},
				new AppBranchHotel
				{
					Id = 7,
					Name = "Tokyo",
					Slug = "tokyo",
					Address = "123 Đường Chuo, Minato City, Tokyo, Nhật Bản",
					QuantityStaff = 35,
					QuantityRoom = 90,
					CreatedDate = now,
					HotelId = 7, // Khách Sạn The Peninsula Tokyo
					Description = "Chi nhánh của The Peninsula Tokyo tại Tokyo"
				},
				new AppBranchHotel
				{
					Id = 8,
					Name = "Cancun",
					Slug = "cancun",
					Address = "700 Boulevard Kukulcan, Cancun, Mexico",
					QuantityStaff = 30,
					QuantityRoom = 75,
					CreatedDate = now,
					HotelId = 8, // Khách Sạn The Ritz-Carlton, Cancun
					Description = "Chi nhánh của The Ritz-Carlton tại Cancun"
				},
				new AppBranchHotel
				{
					Id = 9,
					Name = "Miami",
					Slug = "miami",
					Address = "500 South Florida Avenue, Miami, FL 33131, USA",
					QuantityStaff = 28,
					QuantityRoom = 60,
					CreatedDate = now,
					HotelId = 9, // Khách Sạn The Biltmore Miami
					Description = "Chi nhánh của The Biltmore Miami tại Miami"
				},
				new AppBranchHotel
				{
					Id = 10,
					Name = "Paris",
					Slug = "paris",
					Address = "70 Avenue de La Bourdonnais, 75007 Paris, Pháp",
					QuantityStaff = 45,
					QuantityRoom = 110,
					CreatedDate = now,
					HotelId = 10, // Khách Sạn Shangri-La, Paris
					Description = "Chi nhánh của Shangri-La tại Paris"
				},
				new AppBranchHotel
				{
					Id = 11,
					Name = "Seoul",
					Slug = "seoul",
					Address = "747-7, Sinsa-dong, Gangnam-gu, Seoul, Hàn Quốc",
					QuantityStaff = 50,
					QuantityRoom = 120,
					CreatedDate = now,
					HotelId = 11, // Khách Sạn Grand Hyatt Seoul
					Description = "Chi nhánh của Grand Hyatt tại Seoul"
				},
				new AppBranchHotel
				{
					Id = 12,
					Name = "Bangkok",
					Slug = "bangkok",
					Address = "123, 123/1-3, Thanon Ratchadamri, Lumphini, Pathum Wan, Bangkok, Thái Lan",
					QuantityStaff = 32,
					QuantityRoom = 80,
					CreatedDate = now,
					HotelId = 12, // Khách Sạn Four Seasons Bangkok
					Description = "Chi nhánh của Four Seasons tại Bangkok"
				},
				new AppBranchHotel
				{
					Id = 13,
					Name = "Tokyo",
					Slug = "tokyo",
					Address = "2-6-1 Nishishinjuku, Shinjuku City, Tokyo, Nhật Bản",
					QuantityStaff = 38,
					QuantityRoom = 95,
					CreatedDate = now,
					HotelId = 13, // Khách Sạn Hilton Tokyo
					Description = "Chi nhánh của Hilton tại Tokyo"
				},
				new AppBranchHotel
				{
					Id = 14,
					Name = "Hong Kong",
					Slug = "hong-kong",
					Address = "1 Austin Road West, Tsim Sha Tsui, Hong Kong",
					QuantityStaff = 55,
					QuantityRoom = 130,
					CreatedDate = now,
					HotelId = 14, // Khách Sạn W Hong Kong
					Description = "Chi nhánh của W Hong Kong tại Hong Kong"
				},
				new AppBranchHotel
				{
					Id = 15,
					Name = "Bali",
					Slug = "bali",
					Address = "Nusa Dua, Bali, Indonesia",
					QuantityStaff = 22,
					QuantityRoom = 70,
					CreatedDate = now,
					HotelId = 15, // Khách Sạn The St. Regis Bali
					Description = "Chi nhánh của The St. Regis tại Bali"
				},
				new AppBranchHotel
				{
					Id = 16,
					Name = "Bangkok",
					Slug = "bangkok",
					Address = "48-5, Thanon Ruam Rudee, Lumphini, Pathum Wan, Bangkok, Thái Lan",
					QuantityStaff = 35,
					QuantityRoom = 85,
					CreatedDate = now,
					HotelId = 16, // Khách Sạn Mandarin Oriental Bangkok
					Description = "Chi nhánh của Mandarin Oriental tại Bangkok"
				},
				new AppBranchHotel
				{
					Id = 17,
					Name = "Paris",
					Slug = "paris",
					Address = "228 Rue de Rivoli, 75001 Paris, Pháp",
					QuantityStaff = 60,
					QuantityRoom = 140,
					CreatedDate = now,
					HotelId = 17, // Khách Sạn Le Meurice, Paris
					Description = "Chi nhánh của Le Meurice tại Paris"
				},
				new AppBranchHotel
				{
					Id = 18,
					Name = "Mumbai",
					Slug = "mumbai",
					Address = "Balaji Towers, Juhu Beach, Mumbai, Ấn Độ",
					QuantityStaff = 30,
					QuantityRoom = 75,
					CreatedDate = now,
					HotelId = 18, // Khách Sạn The Oberoi, Mumbai
					Description = "Chi nhánh của The Oberoi tại Mumbai"
				},
				new AppBranchHotel
				{
					Id = 19,
					Name = "Sydney",
					Slug = "sydney",
					Address = "7 Hickson Rd, Millers Point, Sydney, Australia",
					QuantityStaff = 29,
					QuantityRoom = 60,
					CreatedDate = now,
					HotelId = 19, // Khách Sạn Park Hyatt Sydney
					Description = "Chi nhánh của Park Hyatt tại Sydney"
				},
				new AppBranchHotel
				{
					Id = 20,
					Name = "Bangkok",
					Slug = "bangkok",
					Address = "5/5-7 Thanon Sukhumvit 23, Khlong Toei Nuea, Watthana, Bangkok, Thái Lan",
					QuantityStaff = 33,
					QuantityRoom = 80,
					CreatedDate = now,
					HotelId = 20, // Khách Sạn The Sukhothai Bangkok
					Description = "Chi nhánh của The Sukhothai tại Bangkok"
				},
				new AppBranchHotel
				{
					Id = 21,
					Name = "Paris",
					Slug = "paris",
					Address = "15 Place Vendôme, 75001 Paris, Pháp",
					QuantityStaff = 50,
					QuantityRoom = 125,
					CreatedDate = now,
					HotelId = 21, // Khách Sạn Ritz Paris
					Description = "Chi nhánh của Ritz Paris tại Paris"
				},
				new AppBranchHotel
				{
					Id = 22,
					Name = "Mumbai",
					Slug = "mumbai",
					Address = "Mahalaxmi, Mumbai, Ấn Độ",
					QuantityStaff = 30,
					QuantityRoom = 75,
					CreatedDate = now,
					HotelId = 22, // Khách Sạn Taj Mahal Palace, Mumbai
					Description = "Chi nhánh của Taj Mahal Palace tại Mumbai"
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
					HotelId = 23, // Khách Sạn St. Regis New York
					Description = "Chi nhánh của St. Regis tại New York"
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
					HotelId = 24, // Khách Sạn Jumeirah, Dubai
					Description = "Chi nhánh của Jumeirah tại Dubai"
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
					HotelId = 25, // Khách Sạn Belmond Hotel Caruso
					Description = "Chi nhánh của Belmond Hotel Caruso tại Italy"
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
					HotelId = 26, // Khách Sạn Banyan Tree, Phuket
					Description = "Chi nhánh của Banyan Tree tại Phuket"
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
					HotelId = 27, // Khách Sạn The Address, Dubai
					Description = "Chi nhánh của The Address tại Dubai"
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
					HotelId = 28, // Khách Sạn Shangri-La, Bangkok
					Description = "Chi nhánh của Shangri-La tại Bangkok"
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
					HotelId = 29, // Khách Sạn The Oberoi, Bali
					Description = "Chi nhánh của The Oberoi tại Bali"
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
					HotelId = 30, // Khách Sạn Aman Tokyo
					Description = "Chi nhánh của Aman tại Tokyo"
				},
				new AppBranchHotel
				{
					Id = 31,
					Name = "Hà Nội",
					Slug = "ha-noi-2",
					Address = "Hà Nội, Việt Nam",
					QuantityStaff = 20,
					QuantityRoom = 50,
					CreatedDate = now,
					HotelId = 2, // Rex Hotel Saigon
					Description = "Chi nhánh của Rex Hotel Saigon tại Hà Nội"
				},
				new AppBranchHotel
				{
					Id = 32,
					Name = "TP. Hồ Chí Minh",
					Slug = "tp-ho-chi-minh-2",
					Address = "TP. Hồ Chí Minh, Việt Nam",
					QuantityStaff = 25,
					QuantityRoom = 80,
					CreatedDate = now,
					HotelId = 3, // Khách Sạn Đà Nẵng Golden Bay
					Description = "Chi nhánh của Đà Nẵng Golden Bay tại TP. Hồ Chí Minh"
				},
				new AppBranchHotel
				{
					Id = 33,
					Name = "Đà Nẵng",
					Slug = "da-nang-2",
					Address = "Đà Nẵng, Việt Nam",
					QuantityStaff = 15,
					QuantityRoom = 40,
					CreatedDate = now,
					HotelId = 4, // Khách Sạn Nha Trang Lodge
					Description = "Chi nhánh của Nha Trang Lodge tại Đà Nẵng"
				},
				new AppBranchHotel
				{
					Id = 34,
					Name = "Nha Trang",
					Slug = "nha-trang-2",
					Address = "Nha Trang, Việt Nam",
					QuantityStaff = 18,
					QuantityRoom = 60,
					CreatedDate = now,
					HotelId = 5, // Khách Sạn Imperial Hải Phòng
					Description = "Chi nhánh của Imperial Hải Phòng tại Nha Trang"
				},
				new AppBranchHotel
				{
					Id = 35,
					Name = "Hải Phòng",
					Slug = "hai-phong-2",
					Address = "Hải Phòng, Việt Nam",
					QuantityStaff = 12,
					QuantityRoom = 30,
					CreatedDate = now,
					HotelId = 6, // Khách Sạn Langham, New York
					Description = "Chi nhánh của Langham Hotel tại Hải Phòng"
				},
				new AppBranchHotel
				{
					Id = 36,
					Name = "New York",
					Slug = "new-york-2",
					Address = "New York, USA",
					QuantityStaff = 40,
					QuantityRoom = 100,
					CreatedDate = now,
					HotelId = 7, // Khách Sạn The Peninsula Tokyo
					Description = "Chi nhánh của The Peninsula tại New York"
				},
				new AppBranchHotel
				{
					Id = 37,
					Name = "Tokyo",
					Slug = "tokyo-2",
					Address = "Tokyo, Nhật Bản",
					QuantityStaff = 35,
					QuantityRoom = 90,
					CreatedDate = now,
					HotelId = 8, // Khách Sạn The Ritz-Carlton, Cancun
					Description = "Chi nhánh của The Ritz-Carlton tại Tokyo"
				},
				new AppBranchHotel
				{
					Id = 38,
					Name = "Cancun",
					Slug = "cancun-2",
					Address = "Cancun, Mexico",
					QuantityStaff = 30,
					QuantityRoom = 75,
					CreatedDate = now,
					HotelId = 9, // Khách Sạn The Biltmore Miami
					Description = "Chi nhánh của The Biltmore tại Cancun"
				},
				new AppBranchHotel
				{
					Id = 39,
					Name = "Miami",
					Slug = "miami-2",
					Address = "Miami, USA",
					QuantityStaff = 28,
					QuantityRoom = 60,
					CreatedDate = now,
					HotelId = 10, // Khách Sạn Shangri-La, Paris
					Description = "Chi nhánh của Shangri-La tại Miami"
				},
				new AppBranchHotel
				{
					Id = 40,
					Name = "Paris",
					Slug = "paris-2",
					Address = "Paris, Pháp",
					QuantityStaff = 45,
					QuantityRoom = 110,
					CreatedDate = now,
					HotelId = 11, // Khách Sạn Grand Hyatt Seoul
					Description = "Chi nhánh của Grand Hyatt tại Paris"
				},
				new AppBranchHotel
				{
					Id = 41,
					Name = "Seoul",
					Slug = "seoul-2",
					Address = "Seoul, Hàn Quốc",
					QuantityStaff = 50,
					QuantityRoom = 120,
					CreatedDate = now,
					HotelId = 12, // Khách Sạn Four Seasons Bangkok
					Description = "Chi nhánh của Four Seasons tại Seoul"
				},
				new AppBranchHotel
				{
					Id = 42,
					Name = "Bangkok",
					Slug = "bangkok-2",
					Address = "Bangkok, Thái Lan",
					QuantityStaff = 32,
					QuantityRoom = 80,
					CreatedDate = now,
					HotelId = 13, // Khách Sạn Hilton Tokyo
					Description = "Chi nhánh của Hilton tại Bangkok"
				},
				new AppBranchHotel
				{
					Id = 43,
					Name = "Tokyo",
					Slug = "tokyo-3",
					Address = "Tokyo, Nhật Bản",
					QuantityStaff = 38,
					QuantityRoom = 95,
					CreatedDate = now,
					HotelId = 14, // Khách Sạn W Hong Kong
					Description = "Chi nhánh của W Hong Kong tại Tokyo"
				},
				new AppBranchHotel
				{
					Id = 44,
					Name = "Hong Kong",
					Slug = "hong-kong-2",
					Address = "Hong Kong",
					QuantityStaff = 55,
					QuantityRoom = 130,
					CreatedDate = now,
					HotelId = 15, // Khách Sạn The St. Regis Bali
					Description = "Chi nhánh của The St. Regis tại Hong Kong"
				},
				new AppBranchHotel
				{
					Id = 45,
					Name = "Bali",
					Slug = "bali-2",
					Address = "Bali, Indonesia",
					QuantityStaff = 22,
					QuantityRoom = 70,
					CreatedDate = now,
					HotelId = 16, // Khách Sạn Mandarin Oriental Bangkok
					Description = "Chi nhánh của Mandarin Oriental tại Bali"
				},
				new AppBranchHotel
				{
					Id = 46,
					Name = "Bangkok",
					Slug = "bangkok-3",
					Address = "Bangkok, Thái Lan",
					QuantityStaff = 35,
					QuantityRoom = 85,
					CreatedDate = now,
					HotelId = 17, // Khách Sạn Ritz Paris
					Description = "Chi nhánh của Ritz tại Bangkok"
				},
				new AppBranchHotel
				{
					Id = 47,
					Name = "Paris",
					Slug = "paris-3",
					Address = "Paris, Pháp",
					QuantityStaff = 60,
					QuantityRoom = 140,
					CreatedDate = now,
					HotelId = 18, // Khách Sạn The Oberoi, Mumbai
					Description = "Chi nhánh của The Oberoi tại Paris"
				},
				new AppBranchHotel
				{
					Id = 48,
					Name = "Mumbai",
					Slug = "mumbai-2",
					Address = "Mumbai, Ấn Độ",
					QuantityStaff = 30,
					QuantityRoom = 75,
					CreatedDate = now,
					HotelId = 19, // Khách Sạn Park Hyatt Sydney
					Description = "Chi nhánh của Park Hyatt tại Mumbai"
				},
				new AppBranchHotel
				{
					Id = 49,
					Name = "Sydney",
					Slug = "sydney-2",
					Address = "Sydney, Australia",
					QuantityStaff = 29,
					QuantityRoom = 65,
					CreatedDate = now,
					HotelId = 20, // Khách Sạn The Sukhothai Bangkok
					Description = "Chi nhánh của The Sukhothai tại Sydney"
				},
				new AppBranchHotel
				{
					Id = 50,
					Name = "Bangkok",
					Slug = "bangkok-4",
					Address = "Bangkok, Thái Lan",
					QuantityStaff = 33,
					QuantityRoom = 90,
					CreatedDate = now,
					HotelId = 21, // Khách Sạn Ritz Paris
					Description = "Chi nhánh của Ritz tại Bangkok"
				},
				new AppBranchHotel
				{
					Id = 51,
					Name = "Bali",
					Slug = "bali-3",
					Address = "Bali, Indonesia",
					QuantityStaff = 25,
					QuantityRoom = 65,
					CreatedDate = now,
					HotelId = 22, // Khách Sạn The Leela, Mumbai
					Description = "Chi nhánh của The Leela tại Bali"
				},
				new AppBranchHotel
				{
					Id = 52,
					Name = "Tokyo",
					Slug = "tokyo-4",
					Address = "Tokyo, Nhật Bản",
					QuantityStaff = 37,
					QuantityRoom = 92,
					CreatedDate = now,
					HotelId = 23, // Khách Sạn St. Regis New York
					Description = "Chi nhánh của St. Regis tại Tokyo"
				},
				new AppBranchHotel
				{
					Id = 53,
					Name = "New York",
					Slug = "new-york-3",
					Address = "New York, USA",
					QuantityStaff = 41,
					QuantityRoom = 102,
					CreatedDate = now,
					HotelId = 24, // Khách Sạn Jumeirah, Dubai
					Description = "Chi nhánh của Jumeirah tại New York"
				},
				new AppBranchHotel
				{
					Id = 54,
					Name = "Dubai",
					Slug = "dubai-3",
					Address = "Dubai, UAE",
					QuantityStaff = 53,
					QuantityRoom = 160,
					CreatedDate = now,
					HotelId = 25, // Khách Sạn Belmond Hotel Caruso
					Description = "Chi nhánh của Belmond Hotel Caruso tại Dubai"
				},
				new AppBranchHotel
				{
					Id = 55,
					Name = "Italy",
					Slug = "italy-2",
					Address = "Italy",
					QuantityStaff = 30,
					QuantityRoom = 70,
					CreatedDate = now,
					HotelId = 26, // Khách Sạn Banyan Tree, Phuket
					Description = "Chi nhánh của Banyan Tree tại Italy"
				},
				new AppBranchHotel
				{
					Id = 56,
					Name = "Phuket",
					Slug = "phuket-2",
					Address = "Phuket, Thái Lan",
					QuantityStaff = 32,
					QuantityRoom = 80,
					CreatedDate = now,
					HotelId = 27, // Khách Sạn The Address, Dubai
					Description = "Chi nhánh của The Address tại Phuket"
				},
				new AppBranchHotel
				{
					Id = 57,
					Name = "Dubai",
					Slug = "dubai-4",
					Address = "Dubai, UAE",
					QuantityStaff = 45,
					QuantityRoom = 125,
					CreatedDate = now,
					HotelId = 28, // Khách Sạn Shangri-La, Bangkok
					Description = "Chi nhánh của Shangri-La tại Dubai"
				},
				new AppBranchHotel
				{
					Id = 58,
					Name = "Bangkok",
					Slug = "bangkok-5",
					Address = "Bangkok, Thái Lan",
					QuantityStaff = 35,
					QuantityRoom = 90,
					CreatedDate = now,
					HotelId = 29, // Khách Sạn The Oberoi, Bali
					Description = "Chi nhánh của The Oberoi tại Bangkok"
				},
				new AppBranchHotel
				{
					Id = 59,
					Name = "Bali",
					Slug = "bali-4",
					Address = "Bali, Indonesia",
					QuantityStaff = 27,
					QuantityRoom = 68,
					CreatedDate = now,
					HotelId = 30, // Khách Sạn Aman Tokyo
					Description = "Chi nhánh của Aman tại Bali"
				}

			);
		}
	}
}