using App.Data.Entities.User;
using App.Data.Repositories;
using App.Web.ViewModels.User;
using App.Web.WebConfig.Consts;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace App.Web.Components.UserAtAbout
{
    public class UserAtAboutViewComponent : ViewComponent
    {
        private readonly GenericRepository _repo;

        public UserAtAboutViewComponent(GenericRepository repo)
        {
            _repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await _repo
                   .GetAll<AppUser>(x => x.DeletedDate == null && x.AppRoleId != AppConst.ROLE_CUSTOMER_ID)
                   .OrderBy(x => x.DisplayOrder)
                   .Select(x => new UserVm
                   {
                       Id = x.Id,
                       Avatar = x.Avatar,
                       FullName = x.FullName,
                       RoleName = x.AppRole.Name,
                   })
                   .ToListAsync();
            return View(data);
        }
    }
}