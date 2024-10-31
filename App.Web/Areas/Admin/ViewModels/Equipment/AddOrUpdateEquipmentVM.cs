using App.Share.Attributes;
using App.Share.Consts;
using App.Web.WebConfig.Consts;

namespace App.Web.Areas.Admin.ViewModels.Equipment
{
    public class AddOrUpdateEquipmentVM
    {
        public int? Id { get; set; }

        [AppRequired]
        [AppStringLength(VM.ProductCategoryVM.MIN_LENGTH, DB.AppEquipment.NAME_LENGTH)]
        public string Name { get; set; }

        public string? Description { get; set; }
        public int? TypeEquipmentId { get; set; }
    }
}