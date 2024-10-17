using App.Data.Entities.Room;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.Room
{
    public class AppRoomEquipmentConfig : IEntityTypeConfiguration<AppRoomEquipment>
    {
        public void Configure(EntityTypeBuilder<AppRoomEquipment> builder)
        {
            builder.ToTable(DB.AppRoomEquipment.TABLE_NAME);
            builder.HasKey(x => x.Id);

            // FK - Room
            builder.HasOne(x => x.Room)
                .WithMany(x => x.RoomEquipments)
                .HasForeignKey(x => x.RoomId)
                .OnDelete(DeleteBehavior.Cascade);

            // FK - Equipment
            builder.HasOne(x => x.Equipment)
                .WithMany(x => x.RoomEquipments)
                .HasForeignKey(x => x.EquipmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}