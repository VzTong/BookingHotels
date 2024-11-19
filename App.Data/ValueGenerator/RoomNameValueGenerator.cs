using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using App.Data.Entities.Room; // Ensure this namespace is correct

namespace App.Data.ValueGenerator
{
	public class RoomNameValueGenerator : ValueGenerator<string>
	{
		public override bool GeneratesTemporaryValues => false;

		public override string Next(EntityEntry entry)
		{
			var appRoom = (AppRoom)entry.Entity;
			return $"T0{appRoom.FloorNumber}-{appRoom.RoomNumber}-{appRoom.RoomType.RoomTypeName}";
		}
	}
}