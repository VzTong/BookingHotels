using App.Data.Entities.User.Staff;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.User.Staff
{
	public class AppWorkShiftConfig : IEntityTypeConfiguration<AppWorkShift>
	{
		public void Configure(EntityTypeBuilder<AppWorkShift> builder)
		{
			builder.ToTable(DB.AppWorkShift.TABLE_NAME);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.IsRequired()
				.HasMaxLength(DB.AppWorkShift.NAME_LENGTH);

			// FK - AppWorkShift
			builder.HasOne(x => x.WorkSchedule)
				.WithMany(x => x.WorkShifts)
				.HasForeignKey(x => x.WorkScheduleId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}