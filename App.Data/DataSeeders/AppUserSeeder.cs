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
					Avatar = "/adminLTE/images/users/avatar-3.jpg",
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
					Avatar = "/clientLTE/images/person_3.jpg",
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
					Avatar = "/clientLTE/images/about_2.jpg",
					Passport = "123456789",
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,               // Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 3,              // Vai trò được tạo ở AppRoleSeeder
				}, new AppUser
				{
					Id = 4,
					Username = "full_news_manager",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Hà Nội",
					Email = "fullnewsmanager@gmail.com",
					FullName = "Trần Thúy Hồng",
					PhoneNumber1 = "+84728756123",
					PhoneNumber2 = "+84227459233",
					Avatar = "/clientLTE/images/person_2.jpg",
					CitizenId = 0917673478,
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,               // Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 5,              // Vai trò được tạo ở AppRoleSeeder
				}, new AppUser
				{
					Id = 5,
					Username = "cate_news_manager",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Thành phố Hồ Chí Minh",
					Email = "catenewsmanager@gmail.com",
					FullName = "Nguyên Thị Thanh",
					PhoneNumber1 = "+84728864923",
					PhoneNumber2 = "+84227459873",
					Avatar = "/adminLTE/images/users/avatar-10.jpg",
					CitizenId = 0917674628,
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,               // Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 6,              // Vai trò được tạo ở AppRoleSeeder
				}, new AppUser
				{
					Id = 6,
					Username = "news_manager",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Phú Quốc",
					Email = "newsmanager@gmail.com",
					FullName = "Lê Thanh Hà",
					PhoneNumber1 = "+84752364923",
					PhoneNumber2 = "+84208739873",
					Avatar = "/adminLTE/images/users/avatar-2.jpg",
					CitizenId = 0917987628,
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,               // Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 7,              // Vai trò được tạo ở AppRoleSeeder
				}, new AppUser
				{
					Id = 7,
					Username = "cate_equipment_management",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Phú Quốc",
					Email = "cateequipmentmanagement@gmail.com",
					FullName = "Lê Hồng Thị",
					PhoneNumber1 = "+84752369852",
					PhoneNumber2 = "+84208739842",
					Avatar = "/adminLTE/images/users/avatar-6.jpg",
					CitizenId = 0917987986,
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,               // Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 8,              // Vai trò được tạo ở AppRoleSeeder
				}, new AppUser
				{
					Id = 8,
					Username = "equipment_management",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Hà Tiên",
					Email = "equipmentmanagement@gmail.com",
					FullName = "Huỳnh Dương Thanh",
					PhoneNumber1 = "+84758576323",
					PhoneNumber2 = "+84208739823",
					Avatar = "/adminLTE/images/users/avatar-4.jpg",
					CitizenId = 0987987986,
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,               // Chi nhánh được tạo ở AppBranchHotelSeeder
					AppRoleId = 9,              // Vai trò được tạo ở AppRoleSeeder
				}, new AppUser
				{
					Id = 9,
					Username = "user2",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Tp.Hồ Chí Minh",
					Email = "user2@gmail.com",
					FullName = "Nguyễn Văn Khánh",
					PhoneNumber1 = "+84911234567",
					PhoneNumber2 = "+84987654322",
					Avatar = "/clientLTE/images/person_2.jpg",
					CitizenId = 123456789,
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,
					AppRoleId = 10,
				}, new AppUser
				{
					Id = 10,
					Username = "user3",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Đà Nẵng",
					Email = "user3@gmail.com",
					FullName = "Nguyễn Thị Hồng",
					PhoneNumber1 = "+84921234567",
					PhoneNumber2 = "+84987654323",
					Avatar = "/clientLTE/images/person_3.jpg",
					CitizenId = 234567890,
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,
					AppRoleId = 11,
				}, new AppUser
				{
					Id = 11,
					Username = "user4",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Hải Phòng",
					Email = "user4@gmail.com",
					FullName = "Trần THị Hòa",
					PhoneNumber1 = "+84931234567",
					PhoneNumber2 = "+84987654324",
					Avatar = "/clientLTE/images/person_4.jpg",
					CitizenId = 345678901,
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,
					AppRoleId = 12,
				}, new AppUser
				{
					Id = 12,
					Username = "user5",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Cần Thơ",
					Email = "user5@gmail.com",
					FullName = "Danh Thành Đạt",
					PhoneNumber1 = "+84941234567",
					PhoneNumber2 = "+84987654325",
					Avatar = "/clientLTE/images/person_1.jpg",
					CitizenId = 456789012,
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,
					AppRoleId = 13,
				}, new AppUser
				{
					Id = 13,
					Username = "user6",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "New York",
					Email = "user6@gmail.com",
					FullName = "John Doe",
					PhoneNumber1 = "+12025550123",
					PhoneNumber2 = "+12027450123",
					Avatar = "/clientLTE/images/person_2.jpg",
					Passport = "A12345678",
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,
					AppRoleId = 14,
				}, new AppUser
				{
					Id = 14,
					Username = "user7",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Los Angeles",
					Email = "user7@gmail.com",
					FullName = "Jane Smith",
					PhoneNumber1 = "+12025550124",
					PhoneNumber2 = "+12027450124",
					Avatar = "/clientLTE/images/person_3.jpg",
					Passport = "B23456789",
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,
					AppRoleId = 15,
				}, new AppUser
				{
					Id = 15,
					Username = "user8",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Chicago",
					Email = "user8@gmail.com",
					FullName = "Michael Johnson",
					PhoneNumber1 = "+12025550125",
					PhoneNumber2 = "+12027450125",
					Avatar = "/clientLTE/images/person_4.jpg",
					Passport = "C34567890",
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,
					AppRoleId = 16,
				}, new AppUser
				{
					Id = 16,
					Username = "user9",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Houston",
					Email = "user9@gmail.com",
					FullName = "Emily Davis",
					PhoneNumber1 = "+12025550126",
					PhoneNumber2 = "+12027450126",
					Avatar = "/clientLTE/images/person_1.jpg",
					Passport = "D45678901",
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,
					AppRoleId = 17,
				}, new AppUser
				{
					Id = 17,
					Username = "user10",
					PasswordHash = pwdHash,
					PasswordSalt = pwdSalt,
					Address = "Phoenix",
					Email = "foreign_user5@gmail.com",
					FullName = "David Wilson",
					PhoneNumber1 = "+12025550127",
					PhoneNumber2 = "+12027450127",
					Avatar = "/clientLTE/images/person_2.jpg",
					Passport = "E56789012",
					CreatedBy = -1,
					CreatedDate = now,
					BranchId = null,
					AppRoleId = 18,
				}
			);

			// Add additional admins for the remaining 59 branches
			for (int i = 1; i <= 59; i++)
			{
				builder.HasData(
					new AppUser
					{
						Id = i + 17,
						Username = $"admin_branch_{i}",
						PasswordHash = pwdHash,
						PasswordSalt = pwdSalt,
						Address = $"Branch Address {i}",
						Email = $"admin_branch_{i}@gmail.com",
						FullName = $"Admin Branch {i}",
						PhoneNumber1 = $"+8490000000{i}",
						PhoneNumber2 = $"+8490000001{i}",
						Avatar = $"/adminLTE/images/users/avatar-{((i - 1) % 10) + 1}.jpg",
						CitizenId = 1000000987 + i,
						CreatedBy = 1,
						CreatedDate = now,
						BranchId = i,               // Chi nhánh được tạo ở AppBranchHotelSeeder
						AppRoleId = i + 8,              // Vai trò được tạo ở AppRoleSeeder
					}
				);
			}

			// Add additional full_order_manager users for each branch
			for (int i = 1; i <= 59; i++)
			{
				builder.HasData(
					new AppUser
					{
						Id = i + 76,
						Username = $"full_order_manager_branch_{i}",
						PasswordHash = pwdHash,
						PasswordSalt = pwdSalt,
						Address = $"Branch Address {i}",
						Email = $"full_order_manager_branch_{i}@gmail.com",
						FullName = $"Full Order Manager Branch {i}",
						PhoneNumber1 = $"+8491000000{i}",
						PhoneNumber2 = $"+8491000001{i}",
						Avatar = $"/adminLTE/images/users/avatar-{((i - 1) % 10) + 1}.jpg",
						CitizenId = 2006400987 + i,
						CreatedBy = 1,
						CreatedDate = now,
						BranchId = i,               // Chi nhánh được tạo ở AppBranchHotelSeeder
						AppRoleId = i + 67,         // Vai trò được tạo ở AppRoleSeeder
					}
				);
			}
		}
	}
}