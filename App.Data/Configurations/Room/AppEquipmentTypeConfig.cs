using App.Data.Entities.Room;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.Configurations.Room
{
	public class AppEquipmentTypeConfig : IEntityTypeConfiguration<AppEquipmentType>
	{
		public void Configure(EntityTypeBuilder<AppEquipmentType> builder)
		{
			builder.ToTable(DB.AppEquipmentType.TABLE_NAME);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.IsRequired()
				.HasMaxLength(DB.AppEquipmentType.NAME_LENGTH);
		}
	}
}