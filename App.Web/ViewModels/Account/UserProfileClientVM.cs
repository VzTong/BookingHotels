using App.Share.Attributes;

namespace App.Web.ViewModels.Account
{
	public class UserProfileClientVM
	{
		[AppRequired]
		public string FullName { get; set; }
		[AppRequired]
		[AppPhone]
		public string PhoneNumber1 { get; set; }
		[AppPhone]
		public string PhoneNumber2 { get; set; }
		[AppRequired]
		[AppEmail]
		public string Email { get; set; }
		[AppRequired]
		public string Address { get; set; }
	}
}