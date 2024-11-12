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

			// Grant full permissions of AppEquipment and AppEquipmentType to an employee
			var employeeRoleId = 2; // Assuming the employee role has an AppRoleId of 2
			var employeePermissions = new List<AppRolePermission>();

			var appEquipmentPermissions = GetConstants(typeof(AuthConst.AppEquipment));
			var appTypeEquipmentPermissions = GetConstants(typeof(AuthConst.AppEquipmentType));

			foreach (var permission in appEquipmentPermissions)
			{
				employeePermissions.Add(new AppRolePermission
				{
					Id = ++i,
					MstPermissionId = Convert.ToInt32(permission.GetRawConstantValue()),
					UpdatedDate = now,
					CreatedDate = now,
					AppRoleId = employeeRoleId,
				});
			}

			foreach (var permission in appTypeEquipmentPermissions)
			{
				employeePermissions.Add(new AppRolePermission
				{
					Id = ++i,
					MstPermissionId = Convert.ToInt32(permission.GetRawConstantValue()),
					UpdatedDate = now,
					CreatedDate = now,
					AppRoleId = employeeRoleId,
				});
			}

			rolePermission.AddRange(employeePermissions);

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