using App.Data.Entities.Room;
using App.Data.Entities.User;
using App.Data.Repositories;
using App.Share.Consts;
using App.Share.Extensions;
using App.Web.ViewModels.Order;
using App.Web.ViewModels.Room;
using App.Web.WebConfig;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using X.PagedList;

namespace App.Web.Controllers
{
	public class RoomController : AppControllerBase
	{
		private readonly INotyfService _notyf;

		public RoomController(IMapper mapper, GenericRepository repo, INotyfService notyf) : base(mapper, repo)
		{
			_notyf = notyf;
		}

		public async Task<IActionResult> Index(SearchRoomClientVM search, int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			ViewBag.Addr = search.Addr;
			ViewBag.Adults = search.Adults;
			ViewBag.CheckInTime_Expected = search.CheckInTime_Expected;
			ViewBag.CheckOutTime_Expected = search.CheckOutTime_Expected;

			var data = await GetListRoomAsync(search, page, size);

			if (search.Addr.IsNullOrEmpty()
				&& !search.CheckInTime_Expected.HasValue
				&& !search.CheckOutTime_Expected.HasValue
				&& search.Adults is null)
			{
				SetErrorMesg("Hãy điền ít nhất 1 trường dữ liệu để tìm kiếm");
				return RedirectToAction("Index", "Home");
			}
			return View(data);
		}

		private async Task<IPagedList<RoomVM>> GetListRoomAsync(SearchRoomClientVM search, int page, int size)
		{
			var defaultWhere = _repository.GetDefaultWhereExpr<AppRoom>(false);
			var query = _repository.DbContext
							.AppRooms
							.AsNoTracking()
							.Where(defaultWhere);

			#region Search
			//  Lọc theo thanh search
			if (!search.Addr.IsNullOrEmpty())
			{
				query = query.Where(x => x.Branch.Address.Contains(search.Addr));
			}
			if (search.Adults.HasValue)
			{
				query = query.Where(x => x.RoomTypeId == search.Adults);
			}
			if(search.CheckInTime_Expected.HasValue)
			{
				// Tạo thông tin đặt hàng nếu đã đăng nhập
				if (User.Identity.IsAuthenticated)
				{
					var orderData = new OrderDataVM
					{
						CheckInTime_Expected = search.CheckInTime_Expected.Value
					};
				}
			}
			if(search.CheckOutTime_Expected.HasValue)
			{
				// Tạo thông tin đặt hàng nếu đã đăng nhập
				if (User.Identity.IsAuthenticated)
				{
					var orderData = new OrderDataVM
					{
						CheckOutTime_Expected = search.CheckOutTime_Expected.Value
					};
				}
			}
			#endregion

			var data = (await query.Where(m => m.DeletedDate == null
									&& (m.Status == DB.RoomStatus.STATUS_CHECKOUT_NAME
									|| m.Status == DB.RoomStatus.STATUS_CANCELED_NAME)
									&& m.IsActive == true)
									.OrderByDescending(m => m.DisplayOrder)
									.ThenByDescending(m => m.Id)
									.ProjectTo<RoomVM>(AutoMapperProfile.RoomsIndexClientConf)
									.ToPagedListAsync(page, size));

			// Check if the result is empty and set a flag in ViewBag
			if (!data.Any())
			{
				ViewBag.NoResultsFound = true;
			}

			return data;
		}

		public async Task<IActionResult> Detail(int id)
		{
			var data = await _repository
				.GetAll<AppRoom>(m => m.Id == id)
				.Include(m => m.ImgRooms)
				.Include(m => m.RoomEquipments)
					.ThenInclude(re => re.Equipment)
				.Include(m => m.RoomType)
				.Include(m => m.Branch)
					.ThenInclude(b => b.Hotel)
				.FirstOrDefaultAsync();

			if (data == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index));
			}

			var vm = _mapper.Map<RoomDetailVM>(data);
			return View(vm);
		}
	}
}