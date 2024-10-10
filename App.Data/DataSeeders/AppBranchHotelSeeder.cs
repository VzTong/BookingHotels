using App.Data.Entities.Hotel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppBranchHotelSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppBranchHotel> builder)
		{
			var now = new DateTime(year: 2021, month: 12, day: 10);

			// Tạo chi nhánh khách sạn
			builder.HasData(
				new AppBranchHotel
				{
					Id = 1,
					Name = "Hà Nội",
					Slug = "ha-noi",
					Address = "Hà Nội, Việt Nam"
				},
				new AppBranchHotel
				{
					Id = 2,
					Name = "TP. Hồ Chí Minh",
					Slug = "tp-ho-chi-minh",
					Address = "TP. Hồ Chí Minh, Việt Nam"
				},
				new AppBranchHotel
				{
					Id = 3,
					Name = "Đà Nẵng",
					Slug = "da-nang",
					Address = "Đà Nẵng, Việt Nam"
				},
				new AppBranchHotel
				{
					Id = 4,
					Name = "Nha Trang",
					Slug = "nha-trang",
					Address = "Nha Trang, Việt Nam"
				},
				new AppBranchHotel
				{
					Id = 5,
					Name = "Hải Phòng",
					Slug = "hai-phong",
					Address = "Hải Phòng, Việt Nam"
				},
				new AppBranchHotel
				{
					Id = 6,
					Name = "California",
					Slug = "california",
					Address = "California, United States"
				},
				new AppBranchHotel
				{
					Id = 7,
					Name = "New York",
					Slug = "new-york",
					Address = "New York, United States"
				},
				new AppBranchHotel
				{
					Id = 8,
					Name = "Texas",
					Slug = "texas",
					Address = "Texas, United States"
				},
				new AppBranchHotel
				{
					Id = 9,
					Name = "Florida",
					Slug = "florida",
					Address = "Florida, United States"
				},
				new AppBranchHotel
				{
					Id = 10,
					Name = "Illinois",
					Slug = "illinois",
					Address = "Illinois, United States"
				},
				new AppBranchHotel
				{
					Id = 11,
					Name = "Tokyo",
					Slug = "tokyo",
					Address = "Tokyo, Japan"
				},
				new AppBranchHotel
				{
					Id = 12,
					Name = "Osaka",
					Slug = "osaka",
					Address = "Osaka, Japan"
				},
				new AppBranchHotel
				{
					Id = 13,
					Name = "Kyoto",
					Slug = "kyoto",
					Address = "Kyoto, Japan"
				},
				new AppBranchHotel
				{
					Id = 14,
					Name = "Hokkaido",
					Slug = "hokkaido",
					Address = "Hokkaido, Japan"
				},
				new AppBranchHotel
				{
					Id = 15,
					Name = "Fukuoka",
					Slug = "fukuoka",
					Address = "Fukuoka, Japan"
				},
				new AppBranchHotel
				{
					Id = 16,
					Name = "Delhi",
					Slug = "delhi",
					Address = "Delhi, India"
				},
				new AppBranchHotel
				{
					Id = 17,
					Name = "Maharashtra (Mumbai)",
					Slug = "maharashtra-mumbai",
					Address = "Maharashtra, India"
				},
				new AppBranchHotel
				{
					Id = 18,
					Name = "Karnataka (Bangalore)",
					Slug = "karnataka-bangalore",
					Address = "Karnataka, India"
				},
				new AppBranchHotel
				{
					Id = 19,
					Name = "Tamil Nadu (Chennai)",
					Slug = "tamil-nadu-chennai",
					Address = "Tamil Nadu, India"
				},
				new AppBranchHotel
				{
					Id = 20,
					Name = "West Bengal (Kolkata)",
					Slug = "west-bengal-kolkata",
					Address = "West Bengal, India"
				},
				new AppBranchHotel
				{
					Id = 21,
					Name = "New South Wales (Sydney)",
					Slug = "new-south-wales-sydney",
					Address = "New South Wales, Australia"
				},
				new AppBranchHotel
				{
					Id = 22,
					Name = "Victoria (Melbourne)",
					Slug = "victoria-melbourne",
					Address = "Victoria, Australia"
				},
				new AppBranchHotel
				{
					Id = 23,
					Name = "Queensland (Brisbane)",
					Slug = "queensland-brisbane",
					Address = "Queensland, Australia"
				},
				new AppBranchHotel
				{
					Id = 24,
					Name = "Western Australia (Perth)",
					Slug = "western-australia-perth",
					Address = "Western Australia, Australia"
				},
				new AppBranchHotel
				{
					Id = 25,
					Name = "South Australia (Adelaide)",
					Slug = "south-australia-adelaide",
					Address = "South Australia, Australia"
				},
				new AppBranchHotel
				{
					Id = 26,
					Name = "Ontario (Toronto)",
					Slug = "ontario-toronto",
					Address = "Ontario, Canada"
				},
				new AppBranchHotel
				{
					Id = 27,
					Name = "British Columbia (Vancouver)",
					Slug = "british-columbia-vancouver",
					Address = "British Columbia, Canada"
				},
				new AppBranchHotel
				{
					Id = 28,
					Name = "Quebec (Montreal)",
					Slug = "quebec-montreal",
					Address = "Quebec, Canada"
				},
				new AppBranchHotel
				{
					Id = 29,
					Name = "Alberta (Calgary)",
					Slug = "alberta-calgary",
					Address = "Alberta, Canada"
				},
				new AppBranchHotel
				{
					Id = 30,
					Name = "Nova Scotia (Halifax)",
					Slug = "nova-scotia-halifax",
					Address = "Nova Scotia, Canada"
				}
			);
		}
	}
}