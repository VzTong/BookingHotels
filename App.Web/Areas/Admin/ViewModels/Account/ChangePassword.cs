using App.Share.Attributes;
using App.Web.WebConfig.Consts;
using System.ComponentModel.DataAnnotations;

namespace App.Web.Areas.Admin.ViewModels.Account
{
	public class ChangePassword
	{
		[DataType(DataType.Password)]
		[AppRequired]
		public string Pwd { get; set; }

		[DataType(DataType.Password)]
		[AppRequired]
		[AppMinLength(VM.UserVM.PWD_MINLEN)]
		public string NewPwd { get; set; }

		[DataType(DataType.Password)]
        [AppRequired]
        [AppConfirmPwd("NewPwd")]
		public string ConfirmPassword { get; set; }

		public bool LogoutAfterChangePwd { get; set; }
	}
}