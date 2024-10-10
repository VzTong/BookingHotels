using App.Data.Entities.Room;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.Room
{
	public class AppRoomConfig : IEntityTypeConfiguration<AppRoom>
	{
		public void Configure(EntityTypeBuilder<AppRoom> builder)
		{
			builder.ToTable(DB.AppRoom.TABLE_NAME);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.RoomName)
				.IsRequired()
				.HasMaxLength(DB.AppRoom.NAME_LENGTH);

			builder.Property(x => x.RoomNumber)
				.IsRequired()
				.HasMaxLength(DB.AppRoom.ROOM_NUMBER_LENGTH);

			builder.Property(x => x.Slug)
				.HasMaxLength(DB.AppRoom.SLUG_LENGTH);

			builder.Property(x => x.Status)
				.IsRequired()
				.HasMaxLength(DB.AppRoom.STATUS_LENGTH);

			builder.Property(x => x.Price)
				.IsRequired()
				.HasMaxLength(DB.AppRoom.PRICE_LENGTH);

			builder.Property(x => x.DiscountPrice)
				.HasMaxLength(DB.AppRoom.DISCOUNT_PRICE_LENGTH);

			// FK - Branch
			builder.HasOne(x => x.Branch)
				.WithMany(x => x.Rooms)
				.HasForeignKey(x => x.BranchId)
				.OnDelete(DeleteBehavior.Cascade);

			// FK - RoomType
			builder.HasOne(x => x.RoomType)
				.WithMany(x => x.Rooms)
				.HasForeignKey(x => x.RoomTypeId)
				.OnDelete(DeleteBehavior.Cascade);

			// FK - Equipment
			builder.HasOne(x => x.Equipment)
				.WithMany(x => x.Rooms)
				.HasForeignKey(x => x.EquipmentId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}