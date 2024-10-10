using App.Data.Entities.Room;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.Room
{
	public class AppImgRoomConfig : IEntityTypeConfiguration<AppImgRoom>
	{
		public void Configure(EntityTypeBuilder<AppImgRoom> builder)
		{
			builder.ToTable(DB.AppImgRoom.TABLE_NAME);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.ImgSrc)
				.IsRequired()
				.HasMaxLength(DB.AppImgRoom.SRC_LENGTH);

			// FK - Room
			builder.HasOne(x => x.Room)
				.WithMany(x => x.ImgRooms)
				.HasForeignKey(x => x.RoomId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}