using App.Data.Entities.User;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.User
{
	public class MstPermissionConfig : IEntityTypeConfiguration<MstPermission>
	{
		public void Configure(EntityTypeBuilder<MstPermission> builder)
		{
			builder.ToTable(DB.MstPermission.TABLE_NAME);
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedNever();

			// CODE là varchar & bắt buộc
			builder.Property(x => x.Code)
				.HasMaxLength(DB.MstPermission.CODE_LENGTH)
				.IsUnicode(false)   // varchar (không chứa unicode)
				.IsRequired();

			builder.Property(x => x.Table)
				.HasMaxLength(DB.MstPermission.TABLE_LENGTH)
				.IsUnicode(false)   // varchar (không chứa unicode)
				.IsRequired();
			builder.Property(x => x.GroupName)
				.HasMaxLength(DB.MstPermission.TABLE_LENGTH)
				.IsUnicode()
				.IsRequired();
			builder.Property(x => x.Desc)
				.HasMaxLength(DB.MstPermission.TABLE_LENGTH)
				.IsUnicode()
				.IsRequired();
		}
	}
}