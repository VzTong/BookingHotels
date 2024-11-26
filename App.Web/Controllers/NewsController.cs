using App.Data.Entities.News;
using App.Data.Entities.User;
using App.Data.Repositories;
using App.Web.ViewModels.News;
using App.Web.WebConfig;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace App.Web.Controllers
{
    public class NewsController : AppControllerBase
    {
        private readonly INotyfService _notyf;

        public NewsController(IMapper mapper, GenericRepository repo, INotyfService notyf) : base(mapper, repo)
        {
            _notyf = notyf;
        }

        public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
        {
            var data = await _repository
                .GetAll<AppNews>()
                .OrderByDescending(m => m.DisplayOrder)
                .ThenByDescending(m => m.Id)
                .ProjectTo<NewsVM>(AutoMapperProfile.NewsIndexClientConf)
                .ToPagedListAsync(page, size);
            
            return View(data);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var data = await _repository.GetOneAsync<AppNews>(x => x.Id == id);
            if (data == null)
            {
                SetErrorMesg(PAGE_NOT_FOUND_MESG);
                return RedirectToAction(nameof(Index));
            }

            var vm = _mapper.Map<NewsVM>(data);
            vm.CreatedByName = _repository.GetOneAsync<AppUser>(x => x.Id == data.CreatedBy).Result.FullName;

            // Fetch popular news
            var popularNews = _repository
                .GetAll<AppNews>(n => n.CategoryId == data.CategoryId)
                .ProjectTo<NewsVM>(AutoMapperProfile.NewsIndexClientConf)
                .FirstOrDefault();

            // Fetch list of popular news
            var popularListNews = await _repository
                .GetAll<AppNews>(n => n.CategoryId == data.CategoryId && n.Id != data.Id)
                .OrderByDescending(n => n.DisplayOrder)
                .Take(5)
                .ProjectTo<NewsVM>(AutoMapperProfile.NewsIndexClientConf)
                .Distinct()
                .ToListAsync();

            // Fetch categories and their news counts
            var categories = await _repository
               .GetAll<AppNewsCategory>()
               .ToListAsync();

            // Calculate news counts for each category
            var categoryNewsCounts = categories
                .Select(c => new
                {
                    Category = c,
                    NewsCount = _repository.GetAll<AppNews>().Count(n => n.CategoryId == c.Id)
                })
                .ToList();

            ViewBag.PopularNews = popularNews;
            ViewBag.PopularListNews = popularListNews;
            ViewBag.Categories = categoryNewsCounts;

            return View(vm);
        }
    }
}