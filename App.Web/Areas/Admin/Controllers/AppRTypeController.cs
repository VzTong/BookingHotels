using App.Data.Entities.Room;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Areas.Admin.ViewModels.RoomType;
using App.Web.Common;
using App.Web.WebConfig;
using App.Web.WebConfig.Consts;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace App.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(AuthenticationSchemes = AppConst.COOKIES_AUTH)]
    public class AppRTypeController : AppControllerBase
    {
        private readonly ILogger<AppRTypeController> _logger;
        readonly GenericRepository _repository;

        public AppRTypeController(GenericRepository repository, ILogger<AppRTypeController> logger, IMapper mapper) : base(mapper, repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [AppAuthorize(AuthConst.AppRoomType.VIEW_LIST)]
        public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
        {
            int? branchId = GetCurrentUserBranchId(); //Truy xuất BranchId của người dùng hiện đang đăng nhập
            ViewBag.BranchId = branchId;

            var query = _repository.GetAll<AppRoomType>();

            // Nếu BranchId không rỗng, hãy lọc người dùng theo BranchId
            if (branchId.HasValue)
            {
                query = (IOrderedQueryable<AppRoomType>)query.Where(u => u.Rooms.Any(b => b.BranchId == branchId.Value));
            }

            // Dự án tới RTypeListItemVM và áp dụng phân trang
            var data = (await query
                .ProjectTo<RTypeListItemVM>(AutoMapperProfile.RTypeIndexConf)
                .ToPagedListAsync(page, size))
                .GenRowIndex();

            // Trả về view với dữ liệu được phân trang
            return View(data);
        }

        [AppAuthorize(AuthConst.AppRoomType.CREATE)]
        [HttpPost]
        public async Task<IActionResult> CreateRType(AddOrUpdateRTypeVM model)
        {
            if (!ModelState.IsValid)
            {
                SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (_repository.GetAll<AppRoomType>().Any(s => s.RoomTypeName.Equals(model.RoomTypeName)))
            {
                SetErrorMesg("Loại phòng này đã tồn tại !");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            try
            {
                var now = DateTime.Now;
                var user = CurrentUserId;
                var rType = _mapper.Map<AppRoomType>(model);
                model.BringPet = rType.BringPet;
                rType.CreatedBy = CurrentUserId;
                rType.CreatedDate = now;

                await _repository.AddAsync(rType);
                SetSuccessMesg($"Thêm loại phòng '{rType.RoomTypeName}' thành công");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            catch (Exception ex)
            {
                LogException(ex);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
        }

        [AppAuthorize(AuthConst.AppRoomType.UPDATE)]
        [HttpPost]
        public async Task<IActionResult> EditRType(AddOrUpdateRTypeVM model)
        {
            var rType = await _repository.FindAsync<AppRoomType>((int)model.Id);
            if (!ModelState.IsValid)
            {
                SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (rType == null)
            {
                SetErrorMesg(PAGE_NOT_FOUND_MESG);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            if (await _repository.AnyAsync<AppRoomType>(u => u.RoomTypeName.ToLower().Equals(model.RoomTypeName.ToLower()) && u.RoomTypeName != rType.RoomTypeName && u.DeletedDate == null))
            {
                SetErrorMesg("Loại phòng này đã tồn tại!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            try
            {
                // Cập nhật các thuộc tính khác của rType
                _mapper.Map<AddOrUpdateRTypeVM, AppRoomType>(model, rType);
                model.BringPet = rType.BringPet;
                rType.UpdatedBy = CurrentUserId;
                rType.UpdatedDate = DateTime.Now;

                await _repository.UpdateAsync(rType);
                SetSuccessMesg($"Cập nhật loại phòng ◜{rType.RoomTypeName}◞ thành công!");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            catch (Exception ex)
            {
                LogException(ex);
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
        }

        [AppAuthorize(AuthConst.AppRoomType.DELETE)]
        public async Task<IActionResult> Delete(int id)
        {
            var rType = await _repository.FindAsync<AppRoomType>(id);
            if (rType == null)
            {
                SetErrorMesg("Loại phòng này không tồn tại hoặc đã được xóa trước đó");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }

            if (await _repository.AnyAsync<AppRoom>(s => s.RoomTypeId.Equals(rType.Id)))
            {
                SetErrorMesg("Thể loại có tồn tại phòng nên không thể xóa !");
                return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
            }
            await _repository.DeleteAsync(rType);
            SetSuccessMesg($"Loại phòng '{rType.RoomTypeName}' được xóa thành công");
            if (Referer != null)
            {
                return Redirect(Referer);
            }
            return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
        }
    }
}