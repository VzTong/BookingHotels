using App.Data.Entities.User;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection;

namespace App.Data.DataSeeders
{
	public static class AppRolePermissionSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppRolePermission> builder)
		{
			var now = new DateTime(year: 2024, month: 10, day: 10);
			// Danh sách các class chứa permission
			Type[] classType = new Type[]
			{
				typeof(AuthConst.AppRole),
				typeof(AuthConst.AppUser),
				typeof(AuthConst.FileManager),
				typeof(AuthConst.AppNews),
				typeof(AuthConst.AppCategoryNews),
				typeof(AuthConst.AppBranchHotel),
				typeof(AuthConst.AppHotel),
				typeof(AuthConst.AppRoom),
				typeof(AuthConst.AppRoomType),
				typeof(AuthConst.AppEquipment),
				typeof(AuthConst.AppEquipmentType),
				typeof(AuthConst.AppOrder),
				typeof(AuthConst.AppPayroll),
				typeof(AuthConst.AppWorkSchedule),
				typeof(AuthConst.AppWorkShift),
			};

			// Cấp quyền cho vai trò
			var rolePermission = new List<AppRolePermission>();
			int i = 0;
			foreach (var type in classType)
			{
				var allPermission = GetConstants(type);
				foreach (var permission in allPermission)
				{
					i++;
					rolePermission.Add(new AppRolePermission
					{
						Id = i,
						MstPermissionId = Convert.ToInt32(permission.GetRawConstantValue()),
						UpdatedDate = now,
						CreatedDate = now,
						AppRoleId = 1,      // Vai trò được tạo ở AppRoleSeeder
					});
				}
			}

			#region Cấp quyền AppEquipment và AppEquipmentType cho nhân viên hệ thống
			var staff_FullEquipmentRoleId = 2; // Assuming the employee role has an AppRoleId of 2
			var staff_CateEquipmentRoleId = 8; // Assuming the employee role has an AppRoleId of 2
			var staff_EquipmentRoleId = 9; // Assuming the employee role has an AppRoleId of 2
			var staff_FullEquipmentPermissions = new List<AppRolePermission>();

			var appEquipmentPermissions = GetConstants(typeof(AuthConst.AppEquipment));
			var appTypeEquipmentPermissions = GetConstants(typeof(AuthConst.AppEquipmentType));

			foreach (var permission in appEquipmentPermissions)
			{
				staff_FullEquipmentPermissions.Add(new AppRolePermission
				{
					Id = ++i,
					MstPermissionId = Convert.ToInt32(permission.GetRawConstantValue()),
					UpdatedDate = now,
					CreatedDate = now,
					AppRoleId = staff_FullEquipmentRoleId,
				});
				staff_FullEquipmentPermissions.Add(new AppRolePermission
				{
					Id = ++i,
					MstPermissionId = Convert.ToInt32(permission.GetRawConstantValue()),
					UpdatedDate = now,
					CreatedDate = now,
					AppRoleId = staff_EquipmentRoleId,
				});
			}

			foreach (var permission in appTypeEquipmentPermissions)
			{
				staff_FullEquipmentPermissions.Add(new AppRolePermission
				{
					Id = ++i,
					MstPermissionId = Convert.ToInt32(permission.GetRawConstantValue()),
					UpdatedDate = now,
					CreatedDate = now,
					AppRoleId = staff_FullEquipmentRoleId,
				});
				staff_FullEquipmentPermissions.Add(new AppRolePermission
				{
					Id = ++i,
					MstPermissionId = Convert.ToInt32(permission.GetRawConstantValue()),
					UpdatedDate = now,
					CreatedDate = now,
					AppRoleId = staff_CateEquipmentRoleId,
				});
			}

			rolePermission.AddRange(staff_FullEquipmentPermissions);
			#endregion

			#region Cấp quyền AppNewsCategory và AppNews cho nhân viên hệ thống'
			var staff_FullNewsRoleId = 5; // Assuming the employee role has an AppRoleId of 2
			var staff_CateNewsRoleId = 6; // Assuming the employee role has an AppRoleId of 2
			var staff_NewsRoleId = 7; // Assuming the employee role has an AppRoleId of 2
			var staff_FullNewsPermissions = new List<AppRolePermission>();

			var appNewsPermissions = GetConstants(typeof(AuthConst.AppNews));
			var appNewsCategoryPermissions = GetConstants(typeof(AuthConst.AppCategoryNews));

			foreach (var permission in appNewsPermissions)
			{
				staff_FullNewsPermissions.Add(new AppRolePermission
				{
					Id = ++i,
					MstPermissionId = Convert.ToInt32(permission.GetRawConstantValue()),
					UpdatedDate = now,
					CreatedDate = now,
					AppRoleId = staff_FullNewsRoleId,
				});
				staff_FullNewsPermissions.Add(new AppRolePermission
				{
					Id = ++i,
					MstPermissionId = Convert.ToInt32(permission.GetRawConstantValue()),
					UpdatedDate = now,
					CreatedDate = now,
					AppRoleId = staff_NewsRoleId,
				});
			}

			foreach (var permission in appNewsCategoryPermissions)
			{
				staff_FullNewsPermissions.Add(new AppRolePermission
				{
					Id = ++i,
					MstPermissionId = Convert.ToInt32(permission.GetRawConstantValue()),
					UpdatedDate = now,
					CreatedDate = now,
					AppRoleId = staff_FullNewsRoleId,
				});
				staff_FullNewsPermissions.Add(new AppRolePermission
				{
					Id = ++i,
					MstPermissionId = Convert.ToInt32(permission.GetRawConstantValue()),
					UpdatedDate = now,
					CreatedDate = now,
					AppRoleId = staff_CateNewsRoleId,
				});
			}

			rolePermission.AddRange(staff_FullNewsPermissions);
			#endregion

			#region Cấp toàn quyền cho admin thuộc chi nhánh 'Hà Nội - Melia Hà Nội'
			var adminBranch1RoleId = 4; // Assuming the employee role has an AppRoleId of 2
			var adminBranch1Permissions = new List<AppRolePermission>();

			foreach (var type in classType)
			{
				var allPermission = GetConstants(type);
				foreach (var permission in allPermission)
				{
					adminBranch1Permissions.Add(new AppRolePermission
					{
						Id = ++i,
						MstPermissionId = Convert.ToInt32(permission.GetRawConstantValue()),
						UpdatedDate = now,
						CreatedDate = now,
						AppRoleId = adminBranch1RoleId,      // Vai trò được tạo ở AppRoleSeeder
					});
				}
			}

			rolePermission.AddRange(adminBranch1Permissions);
			#endregion

			builder.HasData(rolePermission);
		}
		private static List<FieldInfo> GetConstants(Type type)
		{
			FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Public |
				 BindingFlags.Static | BindingFlags.FlattenHierarchy);

			return fieldInfos.Where(fi => fi.IsLiteral && !fi.IsInitOnly).ToList();
		}
	}
}