using App.Data.Entities.Room;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppRoomEquipmentSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppRoomEquipment> builder)
		{
			builder.HasData(
				new AppRoomEquipment
				{
					Id = 1,
					RoomId = 1, // Assuming RoomId 1 corresponds to the first room in AppRoomSeeder
					EquipmentId = 1 // Assuming EquipmentId 1 corresponds to the first equipment in AppEquipmentSeeder
				},
				new AppRoomEquipment
				{
					Id = 2,
					RoomId = 1,
					EquipmentId = 2
				},
				new AppRoomEquipment
				{
					Id = 3,
					RoomId = 1,
					EquipmentId = 3
				},
				new AppRoomEquipment
				{
					Id = 4,
					RoomId = 2, // Assuming RoomId 2 corresponds to the second room in AppRoomSeeder
					EquipmentId = 4
				},
				new AppRoomEquipment
				{
					Id = 5,
					RoomId = 2,
					EquipmentId = 5
				},
				new AppRoomEquipment
				{
					Id = 6,
					RoomId = 2,
					EquipmentId = 6
				}
			// Add more seed data as needed
			);
		}
	}
}