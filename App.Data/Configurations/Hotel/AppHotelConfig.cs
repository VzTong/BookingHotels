using App.Data.Entities.Hotel;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations
{
	public class AppHotelConfig : IEntityTypeConfiguration<AppHotel>
	{
		public void Configure(EntityTypeBuilder<AppHotel> builder)
		{
			builder.ToTable(DB.AppHotel.TABLE_NAME);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.IsRequired()
				.HasMaxLength(DB.AppHotel.NAME_LENGTH);

			builder.Property(x => x.Slug)
				.HasMaxLength(DB.AppHotel.SLUG_LENGTH);

			builder.Property(x => x.Description)
				.HasMaxLength(DB.AppHotel.DESC_LENGTH);

			builder.Property(x => x.PhoneNumber1)
				.IsRequired()
				.HasMaxLength(DB.AppHotel.PHONE_LENGTH);

			builder.Property(x => x.PhoneNumber2)
				.HasMaxLength(DB.AppHotel.PHONE_LENGTH);

			builder.Property(x => x.Email)
				.IsRequired()
				.HasMaxLength(DB.AppHotel.EMAIL_LENGTH);

			builder.Property(m => m.IsActive)
			  .HasDefaultValue(DB.AppHotel.ISACTIVE)
			  .IsRequired();

			builder.Property(x => x.ImgBanner)
				.HasMaxLength(DB.AppHotel.IMG_BANNER_LENGTH);
		}
	}
}