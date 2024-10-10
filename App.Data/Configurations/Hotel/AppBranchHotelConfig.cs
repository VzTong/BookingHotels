using App.Data.Entities.Hotel;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.Hotel
{
	public class AppBranchHotelConfig : IEntityTypeConfiguration<AppBranchHotel>
	{
		public void Configure(EntityTypeBuilder<AppBranchHotel> builder)
		{
			builder.ToTable(DB.AppBranchHotel.TABLE_NAME);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.IsRequired()
				.HasMaxLength(DB.AppBranchHotel.NAME_LENGTH);

			builder.Property(x => x.Slug)
				.HasMaxLength(DB.AppBranchHotel.SLUG_LENGTH);

			builder.Property(x => x.Description)
				.HasMaxLength(DB.AppBranchHotel.DESC_LENGTH);

			builder.Property(x => x.IdMap)
				.HasMaxLength(DB.AppBranchHotel.IDMAP_LENGTH);

			builder.Property(x => x.Address)
				.IsRequired()
				.HasMaxLength(DB.AppBranchHotel.ADDRESS_LENGTH);

			builder.Property(x => x.Img)
				.HasMaxLength(DB.AppBranchHotel.IMG_LENGTH);

			// FK - Hotel
			builder.HasOne(x => x.Hotel)
				.WithMany(x => x.BranchHotels)
				.HasForeignKey(x => x.HotelId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}