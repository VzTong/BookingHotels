using App.Data.Entities.Room;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.ViewModels.Room;
using App.Web.WebConfig;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

		public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			var data = await _repository
				.GetAll<AppRoom>(m => m.DeletedDate == null
									&& (m.Status == DB.RoomStatus.STATUS_CHECKOUT_NAME
									|| m.Status == DB.RoomStatus.STATUS_CANCELED_NAME)
									&& m.IsActive == true)
				.OrderByDescending(m => m.DisplayOrder)
				.ThenByDescending(m => m.Id)
				.ProjectTo<RoomVM>(AutoMapperProfile.RoomsIndexClientConf)
				.ToPagedListAsync(page, size);
			return View(data);
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