namespace App.Web.Areas.Admin.ViewModels.Account
{
	public class UpdateUserViewModel
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public string FullName { get; set; }
		public string PhoneNumber1 { get; set; }
		public string PhoneNumber2 { get; set; }
		public string Avatar { get; set; }
		public IFormFile? AvatarUpload { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public string CitizenId { get; set; }
		public string Passport { get; set; }
		public string Permanent { get; set; }
		public string RoleName { get; set; }
		public string Permission { get; set; }
	}
}