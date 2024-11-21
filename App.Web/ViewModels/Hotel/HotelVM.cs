namespace App.Web.ViewModels.Hotel
{
	public class HotelVM
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string? Slug { get; set; }
		public string? Description { get; set; }
		public string? ImgBanner { get; set; }
		public int? DisplayOrder { get; set; }
	}
}