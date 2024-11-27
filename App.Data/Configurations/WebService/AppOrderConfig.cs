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

			builder.Property(x => x.CusName)
				.HasMaxLength(DB.AppOrder.CUS_NAME_LENGTH);
			builder.Property(x => x.CusPhone)
				.HasMaxLength(DB.AppOrder.CUS_PHONE_LENGTH);
			builder.Property(x => x.CusEmail)
				.HasMaxLength(DB.AppOrder.CUS_EMAIL_LENGTH);
			builder.Property(x => x.CusNote)
				.HasMaxLength(DB.AppOrder.CUS_NOTE_LENGTH);
			builder.Property(x => x.QuantityRoom).IsRequired();

            // FK - AppUser
			builder.HasOne(x => x.Customer)
				.WithMany(x => x.OwnerOrders)
				.HasForeignKey(x => x.CreatedBy)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}