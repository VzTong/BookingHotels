using App.Data.Entities.Room;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppTypeEquipmentSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppEquipmentType> builder)
		{
			var now = new DateTime(year: 2024, month: 10, day: 10);

			// Tạo loại thiết bị
			builder.HasData(
				new AppEquipmentType
				{
					Id = 1,
					Name = "Trang thiết bị phòng khách",
					CreatedDate = now
				},
				
				new AppEquipmentType
				{
					Id = 2,
					Name = "Thiết bị vệ sinh",
					CreatedDate = now
				}
			);
		}
	}
}