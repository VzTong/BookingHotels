using App.Data.Entities.User;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppRoleSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppRole> builder)
		{
			var now = new DateTime(year: 2024, month: 10, day: 10);

			// Tạo vai trò
			var roleAdmin = new AppRole
			{
				Id = 1,
				Name = "Quản trị toàn hệ thống",
				Desc = "Quản trị quản lý toàn bộ hệ thống",
				CreatedDate = now,
				CanDelete = false
			};
			var roleFullEquipment = new AppRole
			{
				Id = 2,
				Name = "Quản trị toàn bộ thiết bị",
				Desc = "Quản trị quản lý toàn bộ về loại và thiết bị",
				CreatedDate = now,
				CanDelete = true
			};
			var roleCustomer = new AppRole
			{
				Id = 3,
				Name = "Khách hàng",
				Desc = "Khách hàng",
				CreatedDate = now,
				CanDelete = true
			};
			var roleFullNews = new AppRole
			{
				Id = 4,
				Name = "Quản trị toàn bộ tin tức",
				Desc = "Quản trị toàn bộ về thể loại và tin tức",
				CreatedDate = now,
				CanDelete = true
			};
			var roleCateNews = new AppRole
			{
				Id = 5,
				Name = "Quản trị thể loại tin tức",
				Desc = "Quản trị toàn bộ thể loại tin tức",
				CreatedDate = now,
				CanDelete = true
			};
			var roleNews = new AppRole
			{
				Id = 6,
				Name = "Quản trị tin tức",
				Desc = "Quản trị toàn bộ tin tức",
				CreatedDate = now,
				CanDelete = true
			};
			var roleCateEquipment = new AppRole
			{
				Id = 7,
				Name = "Quản trị loại thiết bị",
				Desc = "Quản trị quản lý toàn bộ về loại trang thiết bị",
				CreatedDate = now,
				CanDelete = true
			};
			var roleEquipment = new AppRole
			{
				Id = 8,
				Name = "Quản trị thiết bị",
				Desc = "Quản trị quản lý toàn bộ về trang thiết bị",
				CreatedDate = now,
				CanDelete = true
			};

			builder.HasData(
				roleCustomer, roleAdmin,
				roleFullEquipment,
				roleFullNews, roleCateNews,
				roleNews, roleCateEquipment, roleEquipment);

			// Dictionary to map branch IDs to their names
			var branchNames = new Dictionary<int, string>
			{
				{ 1, "Hà Nội - Melia Hà Nội" },
				{ 2, "TP. Hồ Chí Minh - Rex Hotel Sài Gòn" },
				{ 3, "Đà Nẵng - Golden Bay" },
				{ 4, "Nha Trang - Lodge" },
				{ 5, "Hải Phòng - Imperial" },
				{ 6, "New York - Langham" },
				{ 7, "Tokyo - The Peninsula Tokyo" },
				{ 8, "Cancun - The Ritz-Carlton" },
				{ 9, "Miami - The Biltmore Miami" },
				{ 10, "Paris - Shangri-La" },
				{ 11, "Seoul - Grand Hyatt Seoul" },
				{ 12, "Bangkok - Four Seasons" },
				{ 13, "Tokyo - Hilton" },
				{ 14, "Hong Kong - W Hong Kong" },
				{ 15, "Bali - The St. Regis" },
				{ 16, "Bangkok - Mandarin Oriental" },
				{ 17, "Paris - Le Meurice" },
				{ 18, "Mumbai - The Oberoi" },
				{ 19, "Sydney - Park Hyatt" },
				{ 20, "Bangkok - The Sukhothai" },
				{ 21, "Paris - Ritz" },
				{ 22, "Mumbai - Taj Mahal Palace" },
				{ 23, "New York - St. Regis" },
				{ 24, "Dubai - Jumeirah" },
				{ 25, "Italy - Belmond Hotel Caruso" },
				{ 26, "Phuket - Banyan Tree" },
				{ 27, "Dubai - The Address" },
				{ 28, "Bangkok - Shangri-La" },
				{ 29, "Bali - The Oberoi" },
				{ 30, "Tokyo - Aman" },
				{ 31, "Hà Nội - Rex Hotel" },
				{ 32, "TP. Hồ Chí Minh - Golden Bay" },
				{ 33, "Đà Nẵng - Lodge" },
				{ 34, "Nha Trang - Imperial" },
				{ 35, "Hải Phòng - Langham" },
				{ 36, "New York - The Peninsula" },
				{ 37, "Tokyo - The Ritz-Carlton" },
				{ 38, "Cancun - The Biltmore" },
				{ 39, "Miami - Shangri-La" },
				{ 40, "Paris - Grand Hyatt" },
				{ 41, "Seoul - Four Seasons" },
				{ 42, "Bangkok - Hilton" },
				{ 43, "Tokyo - W Hong Kong" },
				{ 44, "Hong Kong - The St. Regis" },
				{ 45, "Bali - Mandarin Oriental" },
				{ 46, "Bangkok - Ritz" },
				{ 47, "Paris - The Oberoi" },
				{ 48, "Mumbai - Park Hyatt" },
				{ 49, "Sydney - The Sukhothai" },
				{ 50, "Bangkok - Ritz" },
				{ 51, "Bali - The Leela" },
				{ 52, "Tokyo - St. Regis" },
				{ 53, "New York - Jumeirah" },
				{ 54, "Dubai - Belmond Hotel Caruso" },
				{ 55, "Italy - Banyan Tree" },
				{ 56, "Phuket - The Address" },
				{ 57, "Dubai - Shangri-La" },
				{ 58, "Bangkok - The Oberoi" },
				{ 59, "Bali - Aman" }
			};

			// Add additional roles for the remaining 59 branches
			for (int i = 1; i <= 59; i++)
			{
				var branchId = i;
				var branchName = branchNames.ContainsKey(branchId) ? branchNames[branchId] : $"{branchId}";

				builder.HasData(
					new AppRole
					{
						Id = i + 8,
						Name = $"Quản trị - Chi nhánh {branchName}".Substring(0, Math.Min(90, $"Quản trị - Chi nhánh {branchName}".Length)),
						Desc = $"Quản trị toàn bộ hệ thống thuộc chi nhánh {branchName}",
						CreatedDate = now,
						CanDelete = true
					}
				);
			}

			// Add additional full_order_manager roles for each branch
			for (int i = 1; i <= 59; i++)
			{
				var branchId = i;
				var branchName = branchNames.ContainsKey(branchId) ? branchNames[branchId] : $"{branchId}";

				builder.HasData(
					new AppRole
					{
						Id = i + 67,
						Name = $"Quản trị đơn hàng - Chi nhánh {branchName}".Substring(0, Math.Min(90, $"Quản trị đơn hàng - Chi nhánh {branchName}".Length)),
						Desc = $"Quản trị toàn bộ đơn hàng thuộc chi nhánh {branchName}",
						CreatedDate = now,
						CanDelete = true
					}
				);
			}

		}
	}
}