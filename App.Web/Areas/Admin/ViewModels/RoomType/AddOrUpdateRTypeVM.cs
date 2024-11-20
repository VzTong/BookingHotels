using App.Share.Attributes;
using App.Share.Consts;
using App.Web.WebConfig.Consts;

namespace App.Web.Areas.Admin.ViewModels.RoomType
{
	public class AddOrUpdateRTypeVM
	{
		public int? Id { get; set; }

		[AppRequired]
		[AppStringLength(VM.ProductCategoryVM.MIN_LENGTH, DB.AppRoomType.NAME_LENGTH)]
		public string RoomTypeName { get; set; }
		public int PeopleStay { get; set; }
		public string? Description { get; set; }
		public bool BringPet { get; set; }
	}
}