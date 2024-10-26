using App.Data.Entities.Hotel;
using App.Data.Entities.News;
using App.Data.Entities.Room;
using App.Data.Entities.User;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.WebConfig.Consts;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(AuthenticationSchemes = AppConst.COOKIES_AUTH)]
	public class HomeController : AppControllerBase
	{
		private readonly ILogger<HomeController> _logger;
		readonly GenericRepository _repository;

		public HomeController(GenericRepository repository, ILogger<HomeController> logger, IMapper mapper) : base(mapper)
		{
			_logger = logger;
			_repository = repository;
		}

		public IActionResult Index()
		{
			ViewBag.CountBranchHotel	= _repository.GetAll<AppBranchHotel>(m => m.DeletedDate == null).Count();
			ViewBag.CountHotel			= _repository.GetAll<AppHotel>(m => m.DeletedDate == null).Count();
			ViewBag.CountRoom			= _repository.GetAll<AppRoom>(m => m.DeletedDate == null).Count();
			ViewBag.CountRoomBooking	= _repository.GetAll<AppRoom>(m => m.Status == DB.RoomStatus.STATUS_BOOKING_NAME).Count();
			ViewBag.CountRoomType		= _repository.GetAll<AppRoomType>(m => m.DeletedDate == null).Count();
			ViewBag.CountEquipment		= _repository.GetAll<AppEquipment>(m => m.DeletedDate == null).Count();
			ViewBag.CountNews			= _repository.GetAll<AppNews>(m => m.DeletedDate == null).Count();
			ViewBag.CountNewsActive		= _repository.GetAll<AppNews>(s => s.Published == true).Count();
			ViewBag.CountUser			= _repository.GetAll<AppUser>(m => m.DeletedDate == null).Count();
			ViewBag.CountUserUnBlock	= _repository.GetAll<AppUser>(m => m.DeletedDate == null && m.BlockedTo == null
																	|| m.DeletedDate == null && m.BlockedTo < DateTime.Now).Count();
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