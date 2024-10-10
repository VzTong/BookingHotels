using App.Data.Entities.Base;

namespace App.Data.Entities.Room
{
	public class AppRoomType : AppEntityBase
	{
        public AppRoomType()
        {
            Rooms = new HashSet<AppRoom>();
        }
        public string RoomTypeName { get; set; }
		public int PeopleStay { get; set; }
		public string? Description { get; set; }
		public bool BringPet { get; set; }

		public ICollection<AppRoom> Rooms { get; set; }
	}
}