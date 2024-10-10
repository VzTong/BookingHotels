using App.Data.Entities.User;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography;
using System.Text;

namespace App.Data.DataSeeders
{
	public static class AppUserSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppUser> builder)
		{
			var now = new DateTime(year: 2024, month: 10, day: 10);

			// Tạo mật khẩu
			var defaultPassword = "123123";
			HMACSHA512 hmac = new();
			var pwByte = Encoding.UTF8.GetBytes(defaultPassword);
			var pwdHash = hmac.ComputeHash(pwByte);
			var pwdSalt = hmac.Key;

			// Tạo thông tin tài khoản admin
			builder.HasData(
				new AppUser
				{
					Id = 1,
					Username = "admin",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Thành phố Hồ Chí Minh",
					Email = "admin_test@gmail.com",
					FullName = "Nguyễn Thanh Long",
					PhoneNumber1 = "+84928666158",
					PhoneNumber2 = "+84928666156",
					CitizenId = 0912345678,
					CreatedBy = -1,
					UpdatedBy = -1,
					UpdatedDate = now,
					CreatedDate = now,
					BranchId = 1,               // Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 1,              // Vai trò được tạo ở AppRoleSeeder
				}, new AppUser
				{
					Id = 2,
					Username = "staff",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Thành phố Cần Thơ",
					Email = "tranthib2001@gmail.com",
					FullName = "Trần Chí Dũng",
					PhoneNumber1 = "+84928666157",
					PhoneNumber2 = "+84928666158",
					CitizenId = 0917635678,
					CreatedBy = -1,
					UpdatedBy = -1,
					UpdatedDate = now,
					CreatedDate = now,
					BranchId = 1,               // Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 2,              // Vai trò được tạo ở AppRoleSeeder
				}, new AppUser
				{
					Id = 3,
					Username = "user1",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "New York City",
					Email = "thanhnguyendt2000@gmail.com",
					FullName = "John Smith",
					PhoneNumber1 = "+12025550123",
					PhoneNumber2 = "+12027450123",
					Passport = "123456789",
					CreatedBy = -1,
					UpdatedBy = -1,
					UpdatedDate = now,
					CreatedDate = now,
					BranchId = 1,               // Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 3,              // Vai trò được tạo ở AppRoleSeeder
				}
			);
		}
	}
}