using App.Data.Entities.Room;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.Room
{
    public class AppEquipmentConfig : IEntityTypeConfiguration<AppEquipment>
    {
        public void Configure(EntityTypeBuilder<AppEquipment> builder)
        {
            builder.ToTable(DB.AppEquipment.TABLE_NAME);
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(DB.AppEquipment.NAME_LENGTH);

            builder.Property(x => x.Description)
                .HasMaxLength(DB.AppEquipment.DESC_LENGTH);

            // FK - TypeEquipment
            builder.HasOne(x => x.TypeEquipment)
                .WithMany(x => x.Equipments)
                .HasForeignKey(x => x.TypeEquipmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}