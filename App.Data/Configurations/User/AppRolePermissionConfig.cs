using App.Data.Entities.User;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.User
{
	public class AppRolePermissionConfig : IEntityTypeConfiguration<AppRolePermission>
	{
		public void Configure(EntityTypeBuilder<AppRolePermission> builder)
		{
			builder.ToTable(DB.AppRolePermission.TABLE_NAME);
			builder.HasKey(x => x.Id);

			// FK - AppRole
			builder.HasOne(x => x.AppRole)
				.WithMany(x => x.AppRolePermissions)
				.HasForeignKey(x => x.AppRoleId);
			//.OnDelete(DeleteBehavior.NoAction);

			// FK - MstPermission
			builder.HasOne(x => x.MstPermission)
				.WithMany(x => x.AppRolePermissions)
				.HasForeignKey(x => x.MstPermissionId);
			//.OnDelete(DeleteBehavior.NoAction);
		}
	}
}