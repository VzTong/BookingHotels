using App.Data.Entities.Room;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppEquipmentSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppEquipment> builder)
		{
			var now = new DateTime(year: 2024, month: 10, day: 10);
			
			// Tạo thiết bị
			builder.HasData(
				new AppEquipment
				{
					Id = 1,
					Name = "Tivi",
					Description = "Tivi 4K 55 inch",
					TypeEquipmentId = 1,
					CreatedDate = now,
					UpdatedDate = now
				},
				
				new AppEquipment
				{
					Id = 2,
					Name = "Điều hòa",
					Description = "Điều hòa 2 chiều",
					TypeEquipmentId = 1,
					CreatedDate = now,
					UpdatedDate = now
				},
				
				new AppEquipment
				{
					Id = 3,
					Name = "Bàn làm việc",
					Description = "Bàn làm việc gỗ",
					TypeEquipmentId = 1,
					CreatedDate = now,
					UpdatedDate = now
				},
				
				new AppEquipment
				{
					Id = 4,
					Name = "Ghế",
					Description = "Ghế xoay",
					TypeEquipmentId = 1,
					CreatedDate = now,
					UpdatedDate = now
				},
				
				new AppEquipment
				{
					Id = 5,
					Name = "Tủ lạnh mini",
					Description = "Tủ lạnh mini 100 lít",
					TypeEquipmentId = 1,
					CreatedDate = now,
					UpdatedDate = now
				},
				
				new AppEquipment
				{
					Id = 6,
					Name = "Bồn cầu",
					Description = "Bồn cầu thông minh",
					TypeEquipmentId = 2,
					CreatedDate = now,
					UpdatedDate = now
				},
				
				new AppEquipment
				{
					Id = 7,
					Name = "Chậu rửa",
					Description = "Chậu rửa thông minh",
					TypeEquipmentId = 2,
					CreatedDate = now,
					UpdatedDate = now
				},
				
				new AppEquipment
				{
					Id = 8,
					Name = "Vòi sen",
					Description = "Vòi sen tăng áp đảo chiều",
					TypeEquipmentId = 2,
					CreatedDate = now,
					UpdatedDate = now
				},
				
				new AppEquipment
				{
					Id = 9,
					Name = "Bồn tắm",
					Description = "Bồn tắm nằm",
					TypeEquipmentId = 2,
					CreatedDate = now,
					UpdatedDate = now
				}
			);
		}
	}
}