namespace App.Web.Areas.Admin.ViewModels.Comment
{
	public class CmtListItemVM : ListItemBaseVM
	{
		public string UserName { get; set; }
		public string Description { get; set; }
		public int Rating { get; set; }
	}
}