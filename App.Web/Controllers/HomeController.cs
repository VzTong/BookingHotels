using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index() => View();

		public IActionResult Contact() => View();

		public IActionResult Privacy() => View();

		public IActionResult About(){
		
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error(int statusCode)
		{
			return View(statusCode.ToString());
		}
	}
}