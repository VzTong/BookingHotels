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
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

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
				ViewBag.CountBranchHotel = _repository.GetAll<AppBranchHotel>(m => m.DeletedDate == null && m.Id == branchId).Count();
				ViewBag.CountHotel = _repository.GetAll<AppHotel>(m => m.DeletedDate == null && m.BranchHotels.Any(b => b.Id == branchId.Value)).Count();
				ViewBag.CountRoom = _repository.GetAll<AppRoom>(m => m.DeletedDate == null && m.BranchId == branchId).Count();
				ViewBag.CountRoomBooking = _repository.GetAll<AppRoom>(m => m.Status == DB.RoomStatus.STATUS_BOOKING_NAME && m.BranchId == branchId).Count();
				ViewBag.CountRoomType = _repository.GetAll<AppRoomType>(m => m.DeletedDate == null && m.Rooms.Any(r => r.BranchId == branchId)).Count();
				ViewBag.CountEquipment = _repository.GetAll<AppEquipment>(m => m.DeletedDate == null && m.RoomEquipments.Any(re => re.Room.BranchId == branchId)).Count();
				ViewBag.CountUser = _repository.GetAll<AppUser>(m => m.DeletedDate == null && m.BranchId == branchId).Count();
				ViewBag.CountNews = _repository.GetAll<AppNews>(m => m.DeletedDate == null && m.Users.BranchId == branchId).Count();
				ViewBag.CountNewsActive = _repository.GetAll<AppNews>(m => m.Published == true && m.Users.BranchId == branchId).Count();
				ViewBag.CountUserUnBlock = _repository.GetAll<AppUser>(m => m.DeletedDate == null && m.BranchId == branchId && (m.BlockedTo == null || m.BlockedTo < DateTime.Now)).Count();
				ViewBag.TotalOrderAmount = _repository.GetAll<AppOrder>(m => m.CreatedDate.HasValue && m.OrderDetails.Any(od => od.Room.BranchId == branchId.Value)).Sum(o => o.TotalPrice);
			}
			else
			{
				ViewBag.CountBranchHotel = _repository.GetAll<AppBranchHotel>(m => m.DeletedDate == null).Count();
				ViewBag.CountHotel = _repository.GetAll<AppHotel>(m => m.DeletedDate == null).Count();
				ViewBag.CountRoom = _repository.GetAll<AppRoom>(m => m.DeletedDate == null).Count();
				ViewBag.CountRoomBooking = _repository.GetAll<AppRoom>(m => m.Status == DB.RoomStatus.STATUS_BOOKING_NAME).Count();
				ViewBag.CountComment = _repository.GetAll<AppComment>().Count();
				ViewBag.CountCommentApproved = _repository.GetAll<AppComment>(m => m.DeletedDate == null).Count();
				ViewBag.CountEquipment = _repository.GetAll<AppEquipment>(m => m.DeletedDate == null).Count();
				ViewBag.CountNews = _repository.GetAll<AppNews>(m => m.DeletedDate == null).Count();
				ViewBag.CountNewsActive = _repository.GetAll<AppNews>(s => s.Published == true).Count();
				ViewBag.CountUser = _repository.GetAll<AppUser>(m => m.DeletedDate == null).Count();
				ViewBag.CountUserUnBlock = _repository.GetAll<AppUser>(m => m.DeletedDate == null && (m.BlockedTo == null || m.BlockedTo < DateTime.Now)).Count();
				ViewBag.TotalOrderAmount = _repository.GetAll<AppOrder>(m => m.CreatedDate.HasValue).Sum(o => o.TotalPrice);
			}

			return View();
		}

		public async Task<IActionResult> GetChartData()
		{
			int? branchId = GetCurrentUserBranchId();

			// Fetch hotel data
			var hotelData = await _repository.GetAll<AppHotel>(m => m.DeletedDate == null
					&& m.CreatedDate.HasValue && (!branchId.HasValue
					|| m.BranchHotels.Any(b => b.Id == branchId.Value)))
				.OrderBy(o => o.CreatedDate.Value)
				.GroupBy(m => new { m.CreatedDate.Value.Year, m.CreatedDate.Value.Month })
				.Select(g => new
				{
					Year = g.Key.Year,
					Month = g.Key.Month,
					TotalHotels = g.Count(),
				})
				.ToListAsync();

			// Fetch revenue data
			var revenueData = await _repository.GetAll<AppOrder>(m => m.CreatedDate.HasValue
							&& (!branchId.HasValue || m.OrderDetails.Any(od => od.Room.BranchId == branchId.Value)))
				.OrderBy(o => o.CreatedDate.Value)
				.GroupBy(m => new { m.CreatedDate.Value.Year, m.CreatedDate.Value.Month })
				.Select(g => new
				{
					Year = g.Key.Year,
					Month = g.Key.Month,
					Total = g.Sum(o => o.TotalPrice)
				})
				.ToListAsync();

			// Fetch booking data 
			var bookingData = await _repository.GetAll<AppRoom>(m => m.Status == DB.RoomStatus.STATUS_BOOKING_NAME && m.CreatedDate.HasValue && (!branchId.HasValue || m.BranchId == branchId))
				.OrderBy(o => o.CreatedDate.Value)
				.GroupBy(m => new { m.CreatedDate.Value.Year, m.CreatedDate.Value.Month })
				.Select(g => new
				{
					Year = g.Key.Year,
					Month = g.Key.Month,
					Count = g.Count()
				})
				.ToListAsync();

			// Prepare the data for the chart
			var chartData = new Dictionary<int, YearData>();

			// Get the range of years and months
			var allYears = hotelData.Select(h => h.Year)
				.Union(revenueData.Select(r => r.Year))
				.Union(bookingData.Select(b => b.Year))
				.Distinct()
				.OrderBy(y => y);

			foreach (var year in allYears)
			{
				var yearData = new YearData
				{
					Series = new List<SeriesData>
					{
						new SeriesData
						{
							Name = "Khách sạn",
							Type = "bar",
							Data = Enumerable.Range(1, 12).Select(month =>
								(decimal)(hotelData.FirstOrDefault(h => h.Year == year && h.Month == month)?.TotalHotels ?? 0)).ToArray()
						},
						new SeriesData
						{
							Name = "Tổng doanh thu",
							Type = "area",
							Data = Enumerable.Range(1, 12).Select(month =>
								revenueData.FirstOrDefault(r => r.Year == year && r.Month == month)?.Total ?? 0m).ToArray()
						},
						new SeriesData
						{
							Name = "Phòng được đặt",
							Type = "bar",
							Data = Enumerable.Range(1, 12).Select(month =>
								(decimal)(bookingData.FirstOrDefault(b => b.Year == year && b.Month == month)?.Count ?? 0)).ToArray()
						}
					}
				};

				chartData[year] = yearData;
			}

			// Log the prepared chart data
			_logger.LogInformation("Chart data prepared: {ChartData}", JsonConvert.SerializeObject(chartData));

			return Ok(chartData);
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
		public class YearData
		{
			public List<SeriesData> Series { get; set; }
		}

		public class SeriesData
		{
			public string Name { get; set; } = string.Empty;
			public string Type { get; set; } = string.Empty;
			public decimal[] Data { get; set; } = Array.Empty<decimal>();
		}
	}
}