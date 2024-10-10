using App.Data.Entities.User;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.User
{
	public class AppRoleConfig : IEntityTypeConfiguration<AppRole>
	{
		public void Configure(EntityTypeBuilder<AppRole> builder)
		{
			builder.ToTable(DB.AppRole.TABLE_NAME);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.HasMaxLength(DB.AppRole.NAME_LENGTH)
				.IsRequired();

			builder.Property(x => x.Desc)
				.HasMaxLength(DB.AppRole.DESC_LENGTH)
				.IsRequired();
		}
	}
}