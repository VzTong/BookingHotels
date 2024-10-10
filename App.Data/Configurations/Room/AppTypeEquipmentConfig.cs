using App.Data.Entities.Room;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.Room
{
	public class AppTypeEquipmentConfig : IEntityTypeConfiguration<AppTypeEquipment>
	{
		public void Configure(EntityTypeBuilder<AppTypeEquipment> builder)
		{
			builder.ToTable(DB.AppTypeEquipment.TABLE_NAME);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.IsRequired()
				.HasMaxLength(DB.AppTypeEquipment.NAME_LENGTH);
		}
	}
}