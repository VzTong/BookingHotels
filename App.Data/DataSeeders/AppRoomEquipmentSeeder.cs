using App.Data.Entities.Room;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppRoomEquipmentSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppRoomEquipment> builder)
		{
			builder.HasData(
				// Room 1 with more than 3 devices
				new AppRoomEquipment { Id = 1, RoomId = 1, EquipmentId = 1 },
				new AppRoomEquipment { Id = 2, RoomId = 1, EquipmentId = 2 },
				new AppRoomEquipment { Id = 3, RoomId = 1, EquipmentId = 3 },
				new AppRoomEquipment { Id = 4, RoomId = 1, EquipmentId = 4 },
				new AppRoomEquipment { Id = 5, RoomId = 1, EquipmentId = 5 },
				// Room 2
				new AppRoomEquipment { Id = 6, RoomId = 2, EquipmentId = 4 },
				new AppRoomEquipment { Id = 7, RoomId = 2, EquipmentId = 5 },
				new AppRoomEquipment { Id = 8, RoomId = 2, EquipmentId = 6 },
				// Room 3 with more than 3 devices
				new AppRoomEquipment { Id = 9, RoomId = 3, EquipmentId = 1 },
				new AppRoomEquipment { Id = 10, RoomId = 3, EquipmentId = 2 },
				new AppRoomEquipment { Id = 11, RoomId = 3, EquipmentId = 3 },
				new AppRoomEquipment { Id = 12, RoomId = 3, EquipmentId = 4 },
				// Room 4
				new AppRoomEquipment { Id = 13, RoomId = 4, EquipmentId = 4 },
				new AppRoomEquipment { Id = 14, RoomId = 4, EquipmentId = 5 },
				new AppRoomEquipment { Id = 15, RoomId = 4, EquipmentId = 6 },
				// Room 5 with more than 3 devices
				new AppRoomEquipment { Id = 16, RoomId = 5, EquipmentId = 1 },
				new AppRoomEquipment { Id = 17, RoomId = 5, EquipmentId = 2 },
				new AppRoomEquipment { Id = 18, RoomId = 5, EquipmentId = 3 },
				new AppRoomEquipment { Id = 19, RoomId = 5, EquipmentId = 4 },
				new AppRoomEquipment { Id = 20, RoomId = 5, EquipmentId = 5 },
				// Room 6
				new AppRoomEquipment { Id = 21, RoomId = 6, EquipmentId = 4 },
				new AppRoomEquipment { Id = 22, RoomId = 6, EquipmentId = 5 },
				new AppRoomEquipment { Id = 23, RoomId = 6, EquipmentId = 6 },
				// Room 7 with more than 3 devices
				new AppRoomEquipment { Id = 24, RoomId = 7, EquipmentId = 1 },
				new AppRoomEquipment { Id = 25, RoomId = 7, EquipmentId = 2 },
				new AppRoomEquipment { Id = 26, RoomId = 7, EquipmentId = 3 },
				new AppRoomEquipment { Id = 27, RoomId = 7, EquipmentId = 4 },
				// Room 8
				new AppRoomEquipment { Id = 28, RoomId = 8, EquipmentId = 4 },
				new AppRoomEquipment { Id = 29, RoomId = 8, EquipmentId = 5 },
				new AppRoomEquipment { Id = 30, RoomId = 8, EquipmentId = 6 },
				// Room 9 with more than 3 devices
				new AppRoomEquipment { Id = 31, RoomId = 9, EquipmentId = 1 },
				new AppRoomEquipment { Id = 32, RoomId = 9, EquipmentId = 2 },
				new AppRoomEquipment { Id = 33, RoomId = 9, EquipmentId = 3 },
				new AppRoomEquipment { Id = 34, RoomId = 9, EquipmentId = 4 },
				// Room 10
				new AppRoomEquipment { Id = 35, RoomId = 10, EquipmentId = 4 },
				new AppRoomEquipment { Id = 36, RoomId = 10, EquipmentId = 5 },
				new AppRoomEquipment { Id = 37, RoomId = 10, EquipmentId = 6 },
				// Room 11 with more than 3 devices
				new AppRoomEquipment { Id = 38, RoomId = 11, EquipmentId = 1 },
				new AppRoomEquipment { Id = 39, RoomId = 11, EquipmentId = 2 },
				new AppRoomEquipment { Id = 40, RoomId = 11, EquipmentId = 3 },
				new AppRoomEquipment { Id = 41, RoomId = 11, EquipmentId = 4 },
				// Room 12
				new AppRoomEquipment { Id = 42, RoomId = 12, EquipmentId = 4 },
				new AppRoomEquipment { Id = 43, RoomId = 12, EquipmentId = 5 },
				new AppRoomEquipment { Id = 44, RoomId = 12, EquipmentId = 6 },
				// Room 13 with more than 3 devices
				new AppRoomEquipment { Id = 45, RoomId = 13, EquipmentId = 1 },
				new AppRoomEquipment { Id = 46, RoomId = 13, EquipmentId = 2 },
				new AppRoomEquipment { Id = 47, RoomId = 13, EquipmentId = 3 },
				new AppRoomEquipment { Id = 48, RoomId = 13, EquipmentId = 4 },
				new AppRoomEquipment { Id = 49, RoomId = 13, EquipmentId = 5 }
			);
		}
	}
}