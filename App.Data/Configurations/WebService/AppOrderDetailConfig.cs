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

            builder.Property(x => x.InvoiceDate)
                .IsRequired();

            builder.Property(x => x.RoomName)
                .IsRequired()
                .HasMaxLength(DB.AppOrderDetail.ROOM_NAME_LENGTH);

            builder.Property(x => x.RoomNumber)
                .IsRequired()
                .HasMaxLength(DB.AppOrderDetail.ROOM_NUMBER_LENGTH);

            builder.Property(x => x.Price)
                .IsRequired()
                .HasMaxLength(DB.AppOrderDetail.PRICE_LENGTH);

            builder.Property(x => x.DiscountPrice)
                .HasMaxLength(DB.AppOrderDetail.PRICE_LENGTH);

            builder.Property(x => x.FullNameUser)
                .IsRequired()
                .HasMaxLength(DB.AppOrderDetail.FULLNAME_USER_LENGTH);

            builder.Property(x => x.QuantityRoom)
                .IsRequired()
                .HasMaxLength(DB.AppOrderDetail.QUANTITY_LENGTH);

            // FK - AppRoom
            builder.HasOne(x => x.Room)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey (x => x.RoomId)
                .OnDelete(DeleteBehavior.Restrict);

            // FK - AppOrder
            builder.HasOne(x => x.Order)
				.WithMany(x => x.OrderDetails)
				.HasForeignKey (x => x.OrderId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}