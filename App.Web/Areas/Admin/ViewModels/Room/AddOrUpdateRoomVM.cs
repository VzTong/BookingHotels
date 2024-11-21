using App.Data.Entities.Room;
using App.Share.Attributes;
using App.Share.Consts;
using App.Web.WebConfig.Consts;
using System.ComponentModel.DataAnnotations;

namespace App.Web.Areas.Admin.ViewModels.Room
{
	public class AddOrUpdateRoomVM
	{
		public int? Id { get; set; }

		[AppRequired]
		public int FloorNumber { get; set; }
		
		[AppRequired]
		public int RoomNumber { get; set; }
		
		[AppRequired]
		[AppStringLength(VM.ProductCategoryVM.MIN_LENGTH, DB.AppRoom.SLUG_LENGTH)]
		public string Status { get; set; }

		[AppRequired]
		[DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
		public double Price { get; set; }

		[DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
		public double? DiscountPrice { get; set; }
		public DateTime? DiscountFrom { get; set; }
		public DateTime? DiscountTo { get; set; }
		public int? BranchId { get; set; }
		public int? RoomTypeId { get; set; }
		public string? LinkImage1 { get; set; }
		public string? LinkImage2 { get; set; }
		public string? LinkImage3 { get; set; }
		public string? LinkImage4 { get; set; }
		public ICollection<AppImgRoom> ProductImages { get; set; }
	}
}