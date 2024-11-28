using App.Share.Attributes;

namespace App.Web.ViewModels.Account
{
	public class UserProfileClientVM
	{
		// Thông tin cơ bản
		public string? Username { get; set; }
		public string? FullName { get; set; }
		[AppPhone]
		public string? PhoneNumber1 { get; set; }
		[AppPhone]
		public string? PhoneNumber2 { get; set; }
		[AppEmail]
		public string? Email { get; set; }
		[AppRequired]
		public string? Address { get; set; }
		public string? Avatar { get; set; }
		public IFormFile? AvatarPath { get; set; }
		public int? CitizenId { get; set; }
		public string? Passport { get; set; }
		public string? Permanent { get; set; }
	}
}