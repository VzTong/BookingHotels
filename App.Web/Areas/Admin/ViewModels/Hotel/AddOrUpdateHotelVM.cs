using App.Data.Entities.Hotel;
using App.Share.Attributes;
using App.Share.Consts;
using App.Web.WebConfig.Consts;

namespace App.Web.Areas.Admin.ViewModels.Hotel
{
    public class AddOrUpdateHotelVM
    {
        public AddOrUpdateHotelVM()
        {
            appBranchHotels = new List<AppBranchHotel>();
        }

        public int? Id { get; set; }

		[AppRequired]
		[AppStringLength(VM.ProductCategoryVM.MIN_LENGTH, DB.AppHotel.NAME_LENGTH)]
		public string Name { get; set; }

		[AppStringLength(VM.ProductCategoryVM.MIN_LENGTH, DB.AppHotel.DESC_LENGTH)]
		public string? Description { get; set; }

		[AppRequired]
		[AppPhone]
		public string PhoneNumber1 { get; set; }

		[AppPhone]
		public string? PhoneNumber2 { get; set; }

		[AppRequired]
		[AppStringLength(VM.ProductCategoryVM.MIN_LENGTH, DB.AppHotel.EMAIL_LENGTH)]
		public string Email { get; set; }
		public string? Img { get; set; }
		public IFormFile? ImgPath { get; set; }
		public List<int>? BranchId { get; set; }  // id chi nhánh input

		public ICollection<AppBranchHotel> appBranchHotels { get; set; }
	}
}
