using App.Web.Areas.Admin.ViewModels.Account;

namespace App.Web.Services.AppUser
{
	public interface IAccountService
	{
		Task<UpdateUserViewModel> GetUserById(int? id);
		Task UpdateUser(AcceptUpdateViewModel data);
	}
}