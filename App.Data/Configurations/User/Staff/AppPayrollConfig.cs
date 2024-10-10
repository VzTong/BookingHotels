using App.Data.Entities.User.Staff;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.User.Staff
{
	public class AppPayrollConfig : IEntityTypeConfiguration<AppPayroll>
	{
		public void Configure(EntityTypeBuilder<AppPayroll> builder)
		{
			builder.ToTable(DB.AppPayroll.TABLE_NAME);
			builder.HasKey(p => p.Id);

			builder.Property(p => p.Salary)
				.IsRequired()
				.HasMaxLength(DB.AppPayroll.SALARY_LENGTH);

			// FK - AppUser (Staff)
			builder.HasOne(x => x.Staff)
				.WithMany(x => x.StaffPayrolls)
				.HasForeignKey(x => x.StaffId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}