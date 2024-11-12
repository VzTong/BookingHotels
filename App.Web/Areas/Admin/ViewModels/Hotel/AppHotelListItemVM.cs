using App.Data.Entities.Hotel;

namespace App.Web.Areas.Admin.ViewModels.Hotel
{
	public class AppHotelListItemVM : ListItemBaseVM
	{
		public string Name { get; set; }
		public string? Slug { get; set; }
		public string? Description { get; set; }
		public string PhoneNumber1 { get; set; }
		public string? PhoneNumber2 { get; set; }
		public string Email { get; set; }
		public bool IsActive { get; set; }
		public string? ImgBanner { get; set; }
		public int? DisplayOrder { get; set; }
		public List<string> BranchName { get; set; }
		public ICollection<AppBranchHotel> AppBranchHotels { get; set; }
	}
}