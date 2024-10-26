namespace App.Web.Areas.Admin.ViewModels.BranchHotel
{
    public class AppBranchHotelListItemVM : ListItemBaseVM
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Address { get; set; }
        public int? QuantityStaff { get; set; }
        public int? QuantityRoom { get; set; }
        public string? Img { get; set; }
	}
}