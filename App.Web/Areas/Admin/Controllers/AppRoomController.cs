using App.Data.Entities.Room;
using App.Data.Repositories;
using App.Share.Consts;
using App.Share.Extensions;
using App.Web.Areas.Admin.ViewModels.Room;
using App.Web.Common;
using App.Web.WebConfig;
using App.Web.WebConfig.Consts;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace App.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(AuthenticationSchemes = AppConst.COOKIES_AUTH)]
	public class AppRoomController : AppControllerBase
	{
		private readonly ILogger<AppRoomController> _logger;
		readonly GenericRepository _repository;

		public AppRoomController(GenericRepository repository, ILogger<AppRoomController> logger, IMapper mapper) : base(mapper, repository)
		{
			_logger = logger;
			_repository = repository;
		}

		[AppAuthorize(AuthConst.AppRoom.VIEW_LIST)]
		public async Task<IActionResult> Index(SearchRoomVM search, int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			int? branchId = GetCurrentUserBranchId(); //Truy xuất BranchId của người dùng hiện đang đăng nhập
			ViewBag.Name = search.Name;
			ViewBag.BranchId = branchId;

			var data = await GetListRoomAsync(search, page, size, branchId);
			return View(data);
		}

		private async Task<IPagedList<RoomListItemVM>> GetListRoomAsync(SearchRoomVM search, int page, int size, int? branchId = null)
		{
			var defaultWhere = _repository.GetDefaultWhereExpr<AppRoom>(false);
			var query = _repository.DbContext
							.AppRooms
							.AsNoTracking()
							.Where(defaultWhere);

			if (branchId.HasValue)
			{
				query = query.Where(x => x.Branch.Id == branchId.Value);
			}

			if (!search.Name.IsNullOrEmpty())
			{
				query = query.Where(x => x.RoomName.Contains(search.Name));
			}
			var data = (await query.OrderByDescending(m => m.DisplayOrder)
									.ThenByDescending(m => m.Id)
									.ProjectTo<RoomListItemVM>(AutoMapperProfile.RoomsIndexConf)
									.ToPagedListAsync(page, size)).GenRowIndex();

			// Check if the result is empty and set a flag in ViewBag
			if (!data.Any())
			{
				ViewBag.NoResultsFound = true;
			}

			return data;
		}

		[AppAuthorize(AuthConst.AppRoom.CREATE)]
		public IActionResult CreateRoom() => View();

		[HttpPost]
		[AppAuthorize(AuthConst.AppRoom.CREATE)]
		public async Task<IActionResult> CreateRoom(AddOrUpdateRoomVM model, [FromServices] IWebHostEnvironment env)
		{
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (_repository.GetAll<AppRoom>().Any(s => s.FloorNumber.Equals(model.FloorNumber) && s.RoomNumber.Equals(model.RoomNumber)))
			{
				SetErrorMesg("phòng này đã tồn tại !");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (model.Price <= model.DiscountPrice)
			{
				SetErrorMesg("Giá khuyến mãi không thể cao hơn hoặc bằng giá gốc !");
				return View(model);
			}
			try
			{
				var imgs = new string[] { model.LinkImage1, model.LinkImage2, model.LinkImage3, model.LinkImage4};
				var now = DateTime.Now;
				for (var i = 0; i < imgs.Length; i++)
				{
					var img = imgs[i] ?? "";

					model.ProductImages.Add(new AppImgRoom
					{
						ImgSrc = img,
						CreatedBy = CurrentUserId,
						UpdatedBy = CurrentUserId,
						CreatedDate = now
					});
				}
				var user = CurrentUserId;

				var room = _mapper.Map<AppRoom>(model);
				room.RoomName = $"T0{room.FloorNumber}•{room.RoomNumber} {room.RoomType.RoomTypeName}";
				room.Slug = StringExtension.Slugify(room.RoomName);
				room.CreatedBy = CurrentUserId;
				room.CreatedDate = now;

				await _repository.AddAsync(room);

				SetSuccessMesg($"Thêm phòng '{room.RoomName}' thành công");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			catch (Exception ex)
			{
				LogException(ex);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
		}

		[AppAuthorize(AuthConst.AppRoom.UPDATE)]
		public async Task<IActionResult> EditRoom(int id)
		{
			var room = await _repository.FindAsync<AppRoom>(id);
			if (room == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index));
			}
			var userEditVM = _mapper.Map<AddOrUpdateRoomVM>(room);
			return View(userEditVM);
		}

		[HttpPost]
		[AppAuthorize(AuthConst.AppUser.UPDATE)]
		public async Task<IActionResult> EditRoom(AddOrUpdateRoomVM model)
		{
			if (!ModelState.IsValid)
			{
				SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
				return View(model);
			}
			if (model.Price <= model.DiscountPrice)
			{
				SetErrorMesg("Giá khuyến mãi không thể cao hơn hoặc bằng giá gốc!");
				return View(model);
			}
			try
			{
				var oldRoom = await _repository.FindAsync<AppRoom>((int)model.Id);

				if (oldRoom is null)
				{
					SetErrorMesg("Không tìm thấy sản phẩm cần cập nhật.");
					return View(model);
				}
				// Cập nhật sản phẩm
				_mapper.Map(model, oldRoom);
				oldRoom.RoomName = $"T0{oldRoom.FloorNumber}•{oldRoom.RoomNumber} {oldRoom.RoomType.RoomTypeName}";
				oldRoom.Slug = StringExtension.Slugify(oldRoom.RoomName);
				await _repository.UpdateAsync(oldRoom);

				// Cập nhật ảnh sản phẩm
				var roomImgs = (await _repository.GetAll<AppImgRoom>(x => x.RoomId == model.Id)
										.ToListAsync());
				// Cố định thứ tự update
				roomImgs = roomImgs.OrderBy(x => x.Id).ToList();
				var imgs = new string[] { model.LinkImage1, model.LinkImage2, model.LinkImage3, model.LinkImage4};
				var now = DateTime.Now;
				for (var i = 0; i < roomImgs.Count; i++)
				{
					var img = imgs[i];
					roomImgs[i].ImgSrc = img;
					roomImgs[i].UpdatedBy = CurrentUserId;
					roomImgs[i].UpdatedDate = now;
				}
				await _repository.UpdateAsync(roomImgs);

				SetSuccessMesg($"Cập nhật phòng '{oldRoom.RoomName}' thành công");
				var indexUrl = Request.Form["beforeUrl"].ToString();
				if (indexUrl.IsNullOrEmpty())
				{
					return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
				}
				return Redirect(indexUrl);
			}
			catch (Exception ex)
			{
				LogException(ex);
				return View(model);
			}
		}

		[AppAuthorize(AuthConst.AppRoom.DELETE)]
		public async Task<IActionResult> Delete(int id)
		{
			var room = await _repository.FindAsync<AppRoom>(id);
			if (room == null)
			{
				SetErrorMesg("phòng này không tồn tại hoặc đã được xóa trước đó");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			// Gỡ khóa ngoại
			room.BranchId = null;

			await _repository.DeleteAsync(room);
			SetSuccessMesg($"phòng '{room.RoomName}' được xóa thành công");
			if (Referer != null)
			{
				return Redirect(Referer);
			}
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}

		[AppAuthorize(AuthConst.AppRoom.PUBLIC)]
		public async Task<IActionResult> PublicRoom(int id)
		{
			var room = await _repository.FindAsync<AppRoom>(id);
			if (room == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			room.IsActive = true;
			await _repository.UpdateAsync(room);
			SetSuccessMesg($"Công khai phòng '{room.RoomName}' thành công");
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}

		[AppAuthorize(AuthConst.AppRoom.UNPUBLIC)]
		public async Task<IActionResult> UnPublicRoom(int id)
		{
			var Room = await _repository.FindAsync<AppRoom>(id);
			if (Room == null)
			{
				SetErrorMesg(PAGE_NOT_FOUND_MESG);
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			Room.IsActive = false;
			await _repository.UpdateAsync(Room);
			SetSuccessMesg($"Gỡ phòng '{Room.RoomName}' thành công");
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}

		public async Task<IActionResult> RoomPin(int id = 0)
		{
			if (id > 0)
			{
				var room = await _repository.FindAsync<AppRoom>(id);
				var maxDisplayOrder = _repository
						.DbContext.AppRooms.Max(x => x.DisplayOrder);
				room.DisplayOrder = maxDisplayOrder != null ? maxDisplayOrder + 1 : 1;
				await _repository.UpdateAsync(room);
			}
			return Redirect(Referer);
		}
		public async Task<IActionResult> RoomUnPin(int id = 0)
		{
			if (id > 0)
			{
				var room = await _repository.FindAsync<AppRoom>(id);
				room.DisplayOrder = null;
				await _repository.UpdateAsync(room);
			}
			return Redirect(Referer);
		}
	}
}