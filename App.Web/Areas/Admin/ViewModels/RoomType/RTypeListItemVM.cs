using App.Data.Entities.Room;

namespace App.Web.Areas.Admin.ViewModels.RoomType
{
	public class RTypeListItemVM : ListItemBaseVM
	{
		public string RoomTypeName { get; set; }
		public int PeopleStay { get; set; }
		public string? Description { get; set; }
		public bool BringPet { get; set; }
		public int? RoomId { get; set; }
		public List<string> RoomName { get; set; }
		public ICollection<AppRoom> AppRooms { get; set; }
	}
}