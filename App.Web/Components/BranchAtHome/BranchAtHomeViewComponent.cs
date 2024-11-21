using App.Data.Entities.Hotel;
using App.Data.Repositories;
using App.Web.ViewModels.Hotel;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace App.Web.Components.BranchAtHome
{
    public class BranchAtHomeViewComponent : ViewComponent
    {
        private readonly GenericRepository _repo;

        public BranchAtHomeViewComponent(GenericRepository repo)
        {
            _repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await _repo
                   .GetAll<AppBranchHotel>(x => x.DeletedDate == null)
                   .OrderBy(x => x.DisplayOrder)
                   .Select(x => new BranchHotelVM
                   {
                       Id = x.Id,
                       Name = x.Name,
                       Img = x.Img,
                   })
                   .Take(5)
                   .ToListAsync();
            return View(data);
        }
    }
}