using App.Data.Entities.Base;

namespace App.Data.Entities.Hotel
{
	public class AppHotel : AppEntityBase
	{
        public AppHotel()
        {
			BranchHotels = new HashSet<AppBranchHotel>();
		}
        public string Name { get; set; }
		public string? Slug { get; set; }
		public string? Description { get; set; }
		public string PhoneNumber1 { get; set; }
		public string? PhoneNumber2 { get; set; }
		public string Email { get; set; }
		public string? ImgBanner { get; set; }

		public ICollection<AppBranchHotel> BranchHotels { get; set; }
	}
}