using App.Data.Entities.service;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.WebService
{
    public class AppOrderDetailConfig : IEntityTypeConfiguration<AppOrderDetail>
    {
        public void Configure(EntityTypeBuilder<AppOrderDetail> builder)
        {
            builder.ToTable(DB.AppOrderDetail.TABLE_NAME);
            builder.HasKey(x => x.Id);

			// FK - AppOrder
			builder.HasOne(x => x.Order)
				.WithMany(x => x.OrderDetails)
				.HasForeignKey(x => x.OrderId)
				.OnDelete(DeleteBehavior.Restrict);

			// FK - AppRoom
			builder.HasOne(x => x.Room)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey (x => x.RoomId)
                .OnDelete(DeleteBehavior.Restrict);

			// FK - AppUser
			builder.HasOne(x => x.Employee)
				.WithMany(x => x.VerifiedOrders)
				.HasForeignKey(x => x.CreatedBy)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}