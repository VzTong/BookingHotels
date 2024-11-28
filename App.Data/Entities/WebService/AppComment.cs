using App.Data.Entities.Base;
using App.Data.Entities.User;

namespace App.Data.Entities.service
{
	public class AppComment : AppEntityBase
	{
		public string Description { get; set; }
		public int Rating { get; set; }

		public AppUser User { get; set; }
	}
}