using App.Share.Attributes;
using App.Share.Consts;
using App.Web.WebConfig.Consts;
using System.ComponentModel.DataAnnotations;

namespace App.Web.Areas.Admin.ViewModels.User
{
	public class UserAddOrEditVM
	{
		public int? Id { get; set; }

		[AppRequired]
		[AppUsername]
		[AppStringLength(VM.UserVM.USERNAME_MINLEN, DB.AppUser.USERNAME_LENGTH)]
		public string Username { get; set; }

		[AppRequired]
		[DataType(DataType.Password)]
		[AppStringLength(VM.UserVM.PWD_MINLEN, DB.AppUser.PWD_LENGTH)]
		public string Password { get; set; }

		[AppRequired]
		[AppConfirmPwd]
		[DataType(DataType.Password)]
		public string ConfirmPwd { get; set; }

		[AppRequired]
		public string FullName { get; set; }

		[AppPhone]
		public string PhoneNumber1 { get; set; }

		[AppPhone]
		public string? PhoneNumber2 { get; set; }

		[AppRequired]
		[AppEmail]
		public string Email { get; set; }
		public string Address { get; set; }
		public int? AppRoleId { get; set; }
		public int? BranchId { get; set; }
		public DateTime? UpdatedDate { get; set; }

		public byte[]? PasswordHash { get; internal set; }
		public byte[]? PasswordSalt { get; internal set; }
	}
}
