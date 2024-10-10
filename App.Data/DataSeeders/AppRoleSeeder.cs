using App.Data.Entities.User;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppRoleSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppRole> builder)
		{
			var now = new DateTime(year: 2021, month: 12, day: 10);

			// Tạo vai trò
			var roleAdmin = new AppRole
			{
				Id = 1,
				Name = "Quản trị hệ thống",
				Desc = "Quản trị toàn bộ hệ thống",
				CreatedDate = now,
				UpdatedDate = now,
				CanDelete = false
			};
			var roleStaff = new AppRole
			{
				Id = 2,
				Name = "Nhân viên",
				Desc = "Nhân viên",
				CreatedDate = now,
				UpdatedDate = now,
				CanDelete = true
			};
			var roleCustomer = new AppRole
			{
				Id = 3,
				Name = "Khách hàng",
				Desc = "Khách hàng",
				CreatedDate = now,
				UpdatedDate = now,
				CanDelete = true
			};

			builder.HasData(roleCustomer, roleAdmin, roleStaff);
		}
	}
}