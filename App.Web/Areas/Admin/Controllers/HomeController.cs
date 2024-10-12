using App.Data;
using App.Data.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	//[Authorize(AuthenticationSchemes = AppConst.COOKIES_AUTH)]
	public class HomeController : AppControllerBase
	{
		private readonly ILogger<HomeController> _logger;
		readonly GenericRepository _repository;

		// Sài automap thì sẽ đổi lại
        //public HomeController(GenericRepository repository, ILogger<HomeController> logger, IMapper mapper) : base(mapper)
        //{
        //	_logger = logger;
        //	_repository = repository;
        //}

        public HomeController(WebAppDbContext db, ILogger<HomeController> logger) : base(db)
		{
			_logger = logger;
		}

        public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error(int statusCode)
		{
			return View(statusCode.ToString().Trim());
		}
	}
}