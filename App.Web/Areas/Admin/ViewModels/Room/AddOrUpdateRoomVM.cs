using App.Data.Entities.Room;
using App.Share.Attributes;
using App.Share.Consts;
using App.Web.Common;
using App.Web.WebConfig.Consts;
using System.ComponentModel.DataAnnotations;

namespace App.Web.Areas.Admin.ViewModels.Room
{
	public class AddOrUpdateRoomVM
	{
		public AddOrUpdateRoomVM()
		{
			ImgRooms = new List<AppImgRoom>();
			RoomEquipments = new List<AppRoomEquipment>();
		}

		public int? Id { get; set; }

		public string? RoomName { get; set; }

		[AppRequired]
		public int FloorNumber { get; set; }
		
		[AppRequired]
		public int RoomNumber { get; set; }
		
		[AppStringLength(VM.ProductCategoryVM.MIN_LENGTH, DB.AppRoom.SLUG_LENGTH)]
		public string? Status { get; set; } = DB.RoomStatus.STATUS_CHECKOUT_NAME;

		[AppRequired]
		[DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
		public double Price { get; set; }

		[DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
		public double? DiscountPrice { get; set; }
		public DateTime? DiscountFrom { get; set; }
		public DateTime? DiscountTo { get; set; }
		public int? BranchId { get; set; }
		public int? RoomTypeId { get; set; }
		public IFormFile LinkImage1 { get; set; }
		public IFormFile LinkImage2 { get; set; }
		public IFormFile LinkImage3 { get; set; }
		public IFormFile LinkImage4 { get; set; }
		public string? LinkImage1_path { get; set; }
		public string? LinkImage2_path { get; set; }
		public string? LinkImage3_path { get; set; }
		public string? LinkImage4_path { get; set; }
		public List<int> EquipmentId { get; set; }  // id thể loại input
		public ICollection<AppImgRoom> ImgRooms { get; set; }
		public ICollection<AppRoomEquipment> RoomEquipments { get; set; }
	}
}