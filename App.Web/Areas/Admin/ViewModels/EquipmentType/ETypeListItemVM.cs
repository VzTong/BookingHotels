using App.Data.Entities.Room;

namespace App.Web.Areas.Admin.ViewModels.EquipmentType
{
	public class ETypeListItemVM : ListItemBaseVM
	{
		public string Name { get; set; }
		public List<string> EquipmentName { get; set; }
		public ICollection<AppEquipment> AppEquipments { get; set; }
	}
}