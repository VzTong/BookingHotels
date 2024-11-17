using App.Data.Entities.Hotel;
using App.Data.Entities.News;
using App.Data.Entities.Room;
using App.Data.Entities.service;
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

		public HomeController(GenericRepository repository, ILogger<HomeController> logger, IMapper mapper) : base(mapper, repository)
		{
			_logger = logger;
			_repository = repository;
		}

		public IActionResult Index()
        {
            int? branchId = GetCurrentUserBranchId();
            ViewBag.BranchId = branchId;
            if (branchId.HasValue)
            {
                ViewBag.CountBranchHotel        = _repository.GetAll<AppBranchHotel>(m => m.DeletedDate == null && m.Id == branchId).Count();
                ViewBag.CountHotel              = _repository.GetAll<AppHotel>(m => m.DeletedDate == null && m.BranchHotels.Any(b => b.Id == branchId.Value)).Count();
                ViewBag.CountRoom               = _repository.GetAll<AppRoom>(m => m.DeletedDate == null && m.BranchId == branchId).Count();
                ViewBag.CountRoomBooking        = _repository.GetAll<AppRoom>(m => m.Status == DB.RoomStatus.STATUS_BOOKING_NAME && m.BranchId == branchId).Count();
                ViewBag.CountRoomType           = _repository.GetAll<AppRoomType>(m => m.DeletedDate == null && m.Rooms.Any(r => r.BranchId == branchId)).Count();
                ViewBag.CountEquipment          = _repository.GetAll<AppEquipment>(m => m.DeletedDate == null && m.RoomEquipments.Any(re => re.Room.BranchId == branchId)).Count();
                ViewBag.CountUser               = _repository.GetAll<AppUser>(m => m.DeletedDate == null && m.BranchId == branchId).Count();
				ViewBag.CountNews               = _repository.GetAll<AppNews>(m => m.DeletedDate == null && m.Users.BranchId == branchId).Count();
				ViewBag.CountNewsActive         = _repository.GetAll<AppNews>(m => m.Published == true && m.Users.BranchId == branchId).Count();
				ViewBag.CountUserUnBlock        = _repository.GetAll<AppUser>(m => m.DeletedDate == null && m.BranchId == branchId && (m.BlockedTo == null || m.BlockedTo < DateTime.Now)).Count();
            }
            else
            {
                ViewBag.CountBranchHotel        = _repository.GetAll<AppBranchHotel>(m => m.DeletedDate == null).Count();
                ViewBag.CountHotel              = _repository.GetAll<AppHotel>(m => m.DeletedDate == null).Count();
                ViewBag.CountRoom               = _repository.GetAll<AppRoom>(m => m.DeletedDate == null).Count();
                ViewBag.CountRoomBooking        = _repository.GetAll<AppRoom>(m => m.Status == DB.RoomStatus.STATUS_BOOKING_NAME).Count();
                ViewBag.CountComment            = _repository.GetAll<AppComment>().Count();
                ViewBag.CountCommentApproved    = _repository.GetAll<AppComment>(m => m.DeletedDate == null).Count();
                ViewBag.CountEquipment          = _repository.GetAll<AppEquipment>(m => m.DeletedDate == null).Count();
                ViewBag.CountNews               = _repository.GetAll<AppNews>(m => m.DeletedDate == null).Count();
                ViewBag.CountNewsActive         = _repository.GetAll<AppNews>(s => s.Published == true).Count();
                ViewBag.CountUser               = _repository.GetAll<AppUser>(m => m.DeletedDate == null).Count();
                ViewBag.CountUserUnBlock        = _repository.GetAll<AppUser>(m => m.DeletedDate == null && (m.BlockedTo == null || m.BlockedTo < DateTime.Now)).Count();
            }

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