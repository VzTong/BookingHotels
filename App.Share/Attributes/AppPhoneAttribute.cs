using App.Share.Consts;
using System.ComponentModel.DataAnnotations;

namespace App.Share.Attributes
{
	public class AppPhoneAttribute : RegularExpressionAttribute
	{
		public AppPhoneAttribute(string pattern = @"^\+*\d{10,15}$") : base(pattern)
		{
			ErrorMessage = AttributeErrMesg.PHONE;
		}
	}
}