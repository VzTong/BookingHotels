using App.Data.Entities.Room;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.Room
{
    public class AppRoomTypeConfig : IEntityTypeConfiguration<AppRoomType>
    {
        public void Configure(EntityTypeBuilder<AppRoomType> builder)
        {
            builder.ToTable(DB.AppRoomType.TABLE_NAME);
            builder.HasKey(x => x.Id);

            builder.Property(x => x.RoomTypeName)
                .IsRequired()
                .HasMaxLength(DB.AppRoomType.NAME_LENGTH);

            builder.Property(x => x.PeopleStay)
                .IsRequired()
                .HasMaxLength(DB.AppRoomType.MAXPEOPLE_LENGTH);

            builder.Property(x => x.Description)
                .HasMaxLength(DB.AppRoomType.DESC_LENGTH);

            builder.Property(x => x.BringPet)
                .IsRequired()
                .HasDefaultValue(DB.AppRoomType.DEFAULT_VALUE);
        }
    }
}