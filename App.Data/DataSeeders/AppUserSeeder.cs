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
					Username = "administrator",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Kiên Giang",
					Email = "administrator@gmail.com",
					FullName = "Nguyễn Thanh Long",
					PhoneNumber1 = "+84928666158",
					PhoneNumber2 = "+84928666156",
					CitizenId = 0912345678,
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,			// Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 1,              // Vai trò được tạo ở AppRoleSeeder
				}, new AppUser
				{
					Id = 2,
					Username = "full_equipment_management",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Thành phố Cần Thơ",
					Email = "fullequipmentmanagement@gmail.com",
					FullName = "Trần Chí Dũng",
					PhoneNumber1 = "+84928666157",
					PhoneNumber2 = "+84928666158",
					CitizenId = 0917635678,
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,               // Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 2,              // Vai trò được tạo ở AppRoleSeeder
				}, new AppUser
				{
					Id = 3,
					Username = "user1",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "New York City",
					Email = "johnsmith1992@gmail.com",
					FullName = "John Smith",
					PhoneNumber1 = "+12025550123",
					PhoneNumber2 = "+12027450123",
					Passport = "123456789",
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = 1,               // Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 3,              // Vai trò được tạo ở AppRoleSeeder
				}, new AppUser
				{
					Id = 4,
					Username = "admin_cn_melia_ha_noi",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Hà Nội",
					Email = "adminmeliahanoi@gmail.com",
					FullName = "Hồ Thành Nhân",
					PhoneNumber1 = "+84725136123",
					PhoneNumber2 = "+84227450123",
					CitizenId = 0917625678,
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = 1,               // Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 4,              // Vai trò được tạo ở AppRoleSeeder
				}, new AppUser
				{
					Id = 5,
					Username = "full_news_manager",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Hà Nội",
					Email = "fullnewsmanager@gmail.com",
					FullName = "Trần Thúy Hồng",
					PhoneNumber1 = "+84728756123",
					PhoneNumber2 = "+84227459233",
					CitizenId = 0917673478,
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,               // Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 5,              // Vai trò được tạo ở AppRoleSeeder
				}, new AppUser
				{
					Id = 6,
					Username = "cate_news_manager",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Thành phố Hồ Chí Minh",
					Email = "catenewsmanager@gmail.com",
					FullName = "Nguyên Văn Toàn",
					PhoneNumber1 = "+84728864923",
					PhoneNumber2 = "+84227459873",
					CitizenId = 0917674628,
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,               // Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 6,              // Vai trò được tạo ở AppRoleSeeder
				}, new AppUser
				{
					Id = 7,
					Username = "news_manager",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Phú Quốc",
					Email = "newsmanager@gmail.com",
					FullName = "Lê Thanh Hà",
					PhoneNumber1 = "+84752364923",
					PhoneNumber2 = "+84208739873",
					CitizenId = 0917987628,
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,               // Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 7,              // Vai trò được tạo ở AppRoleSeeder
				}, new AppUser
				{
					Id = 8,
					Username = "cate_equipment_management",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Phú Quốc",
					Email = "cateequipmentmanagement@gmail.com",
					FullName = "Lê Thành Dương",
					PhoneNumber1 = "+84752369852",
					PhoneNumber2 = "+84208739842",
					CitizenId = 0917987986,
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,               // Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 8,              // Vai trò được tạo ở AppRoleSeeder
				}, new AppUser
				{
					Id = 9,
					Username = "equipment_management",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Hà Tiên",
					Email = "equipmentmanagement@gmail.com",
					FullName = "Huỳnh Dương Trấn",
					PhoneNumber1 = "+84758576323",
					PhoneNumber2 = "+84208739823",
					CitizenId = 0987987986,
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,               // Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 9,              // Vai trò được tạo ở AppRoleSeeder
				}
			);
		}
	}
}