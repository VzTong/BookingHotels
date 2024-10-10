using App.Data.Entities.Room;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppEquipmentSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppEquipment> builder)
		{
			var now = new DateTime(year: 2021, month: 12, day: 10);
			
			// Tạo thiết bị
			builder.HasData(
				new AppEquipment
				{
					Id = 1,
					Name = "Tivi",
					TypeEquipmentId = 1,
					CreatedDate = now,
					UpdatedDate = now
				},
				
				new AppEquipment
				{
					Id = 2,
					Name = "Điều hòa",
					TypeEquipmentId = 1,
					CreatedDate = now,
					UpdatedDate = now
				},
				
				new AppEquipment
				{
					Id = 3,
					Name = "Bàn làm việc",
					TypeEquipmentId = 1,
					CreatedDate = now,
					UpdatedDate = now
				},
				
				new AppEquipment
				{
					Id = 4,
					Name = "Ghế",
					TypeEquipmentId = 1,
					CreatedDate = now,
					UpdatedDate = now
				},
				
				new AppEquipment
				{
					Id = 5,
					Name = "Tủ lạnh mini",
					TypeEquipmentId = 1,
					CreatedDate = now,
					UpdatedDate = now
				},
				
				new AppEquipment
				{
					Id = 6,
					Name = "Bồn cầu",
					TypeEquipmentId = 2,
					CreatedDate = now,
					UpdatedDate = now
				},
				
				new AppEquipment
				{
					Id = 7,
					Name = "Chậu rửa",
					TypeEquipmentId = 2,
					CreatedDate = now,
					UpdatedDate = now
				},
				
				new AppEquipment
				{
					Id = 8,
					Name = "Vòi sen",
					TypeEquipmentId = 2,
					CreatedDate = now,
					UpdatedDate = now
				},
				
				new AppEquipment
				{
					Id = 9,
					Name = "Bồn tắm",
					TypeEquipmentId = 2,
					CreatedDate = now,
					UpdatedDate = now
				}
			);
		}
	}
}