using App.Data.Entities.User.Staff;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.User.Staff
{
	public class AppWorkScheduleConfig : IEntityTypeConfiguration<AppWorkSchedule>
	{
		public void Configure(EntityTypeBuilder<AppWorkSchedule> builder)
		{
			builder.ToTable(DB.AppWorkSchedule.TABLE_NAME);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Day)
				.IsRequired()
				.HasDefaultValueSql(DB.AppWorkSchedule.DEFAULT_DATE);
		}
	}
}