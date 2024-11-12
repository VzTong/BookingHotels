using App.Share.Attributes;
using App.Share.Consts;
using App.Web.WebConfig.Consts;

namespace App.Web.Areas.Admin.ViewModels.EquipmentType
{
	public class AddOrUpdateETypeVM
	{
		public int? Id { get; set; }

		[AppRequired]
		[AppStringLength(VM.ProductCategoryVM.MIN_LENGTH, DB.AppEquipmentType.NAME_LENGTH)]
		public string Name { get; set; }
	}
}