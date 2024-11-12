using App.Data.Entities.service;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.WebService
{
	public class AppOrderConfig : IEntityTypeConfiguration<AppOrder>
	{
		public void Configure(EntityTypeBuilder<AppOrder> builder)
		{
			builder.ToTable(DB.AppOrder.TABLE_NAME);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.CheckInTime)
				.IsRequired();

			builder.Property(x => x.CheckOutTime)
				.IsRequired();

			builder.Property(x => x.TimeStay)
				.IsRequired();

			builder.Property(x => x.TotalPrice)
				.IsRequired()
				.HasMaxLength(DB.AppOrder.TOTAL_LENGTH);

			builder.Property(x => x.Deposit)
				.IsRequired()
				.HasMaxLength(DB.AppOrder.TOTAL_LENGTH);

            builder.Property(x => x.Status)
                .IsRequired()
                .HasMaxLength(DB.AppOrder.STATUS_LENGTH);

            // FK - AppUser
            builder.HasOne(x => x.Employee)
				.WithMany(x => x.VerifiedOrders)
				.HasForeignKey(x => x.EmployeeId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(x => x.Customer)
				.WithMany(x => x.OwnerOrders)
				.HasForeignKey(x => x.CreatedBy)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}