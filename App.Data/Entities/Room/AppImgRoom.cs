using App.Data.Entities.Base;

namespace App.Data.Entities.Room
{
	public class AppImgRoom : AppEntityBase
	{
		public string? ImgSrc { get; set; }
		public int? RoomId { get; set; }

		public AppRoom Room { get; set; }
	}
}