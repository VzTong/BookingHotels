namespace App.Web.Areas.Admin.ViewModels.Equipment
{
	public class EquipmentListItemVM : ListItemBaseVM
	{
		public string Name { get; set; }
		public string? Description { get; set; }
		public int? TypeEquipmentId { get; set; }
		public string? TypeEquipmentName { get; set; }
	}
}