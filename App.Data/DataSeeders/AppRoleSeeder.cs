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
				Name = "Khách hàng - Chi nhánh 'Hà Nội - Melia Hà Nội'",
				Desc = "Khách hàng thuộc chi nhánh 'Hà Nội - Melia Hà Nội'",
				CreatedDate = now,
				CanDelete = true
			};
			var roleAdminBranch = new AppRole
			{
				Id = 4,
				Name = "Quản trị - Chi nhánh 'Hà Nội - Melia Hà Nội'",
				Desc = "Quản trị toàn bộ hệ thống thuộc chi nhánh 'Hà Nội - Melia Hà Nội'",
				CreatedDate = now,
				CanDelete = true
			};
			var roleFullNews = new AppRole
			{
				Id = 5,
				Name = "Quản trị toàn bộ tin tức",
				Desc = "Quản trị toàn bộ về thể loại và tin tức",
				CreatedDate = now,
				CanDelete = true
			};
			var roleCateNews = new AppRole
			{
				Id = 6,
				Name = "Quản trị thể loại tin tức",
				Desc = "Quản trị toàn bộ thể loại tin tức",
				CreatedDate = now,
				CanDelete = true
			};
			var roleNews = new AppRole
			{
				Id = 7,
				Name = "Quản trị tin tức",
				Desc = "Quản trị toàn bộ tin tức",
				CreatedDate = now,
				CanDelete = true
			};
			var roleCateEquipment = new AppRole
			{
				Id = 8,
				Name = "Quản trị loại thiết bị",
				Desc = "Quản trị quản lý toàn bộ về loại trang thiết bị",
				CreatedDate = now,
				CanDelete = true
			};
			var roleEquipment = new AppRole
			{
				Id = 9,
				Name = "Quản trị thiết bị",
				Desc = "Quản trị quản lý toàn bộ về trang thiết bị",
				CreatedDate = now,
				CanDelete = true
			};

			builder.HasData(
					roleCustomer, roleAdmin, 
					roleFullEquipment, roleAdminBranch,
					roleFullNews, roleCateNews, 
					roleNews, roleCateEquipment, roleEquipment);
		}
	}
}