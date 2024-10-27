using App.Share.Attributes;
using App.Share.Consts;
using App.Web.WebConfig.Consts;

namespace App.Web.Areas.Admin.ViewModels.BranchHotel
{
	public class AddOrUpdateBranchHotelVM
	{
		public int? Id { get; set; }
		
		[AppRequired]
		[AppStringLength(VM.ProductCategoryVM.MIN_LENGTH, DB.AppBranchHotel.NAME_LENGTH)]
		public string Name { get; set; }
		
		public string? Description { get; set; }
		
		[AppRequired]
		[AppStringLength(VM.ProductCategoryVM.MIN_LENGTH, DB.AppBranchHotel.ADDRESS_LENGTH)]
		public string Address { get; set; }
		public int? QuantityStaff { get; set; }
		public int? QuantityRoom { get; set; }
		public string? Img { get; set; }
		public IFormFile? ImgPath { get; set; }
		public int? HotelId { get; set; }
        public string? IdMap { get; set; }
    }
}