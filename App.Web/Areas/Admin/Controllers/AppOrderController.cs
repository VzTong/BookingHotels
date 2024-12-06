using App.Data.Entities.Room;
using App.Data.Entities.service;
using App.Data.Repositories;
using App.Share.Consts;
using App.Share.Extensions;
using App.Web.Areas.Admin.ViewModels.Order;
using App.Web.Common;
using App.Web.WebConfig;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace App.Web.Areas.Admin.Controllers
{
	public class AppOrderController : AppControllerBase
	{
		private readonly ILogger<AppOrderController> _logger;
		readonly GenericRepository _repository;

		public AppOrderController(GenericRepository repository, ILogger<AppOrderController> logger, IMapper mapper) : base(mapper, repository)
		{
			_logger = logger;
			_repository = repository;
		}

		[AppAuthorize(AuthConst.AppOrder.VIEW_LIST)]
		public async Task<IActionResult> Index(SearchOrderVM search, int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			int? branchId = GetCurrentUserBranchId(); //Truy xuất BranchId của người dùng hiện đang đăng nhập
			ViewBag.Name = search.UserName;
			ViewBag.BranchId = branchId;

			var data = await GetListOrderAsync(search, page, size, branchId);
			return View(data);
		}

		private async Task<IPagedList<ListItemOrderVM>> GetListOrderAsync(SearchOrderVM search, int page, int size, int? branchId = null)
		{
			var defaultWhere = _repository.GetDefaultWhereExpr<AppOrder>(false);
			var query = _repository.DbContext
							.AppOrders
							.AsNoTracking()
							.Where(defaultWhere);

			if (branchId.HasValue)
			{
				query = query.Where(x => x.OrderDetails.Any(b => b.Room.BranchId == branchId.Value));
			}

			if (!search.UserName.IsNullOrEmpty())
			{
				query = query.Where(x => x.CusName.Contains(search.UserName));
			}
			var data = (await query.OrderByDescending(x => x.Id)
									.ProjectTo<ListItemOrderVM>(AutoMapperProfile.OrderIndexConf)
									.ToPagedListAsync(page, size)).GenRowIndex();

			// Check if the result is empty and set a flag in ViewBag
			if (!data.Any())
			{
				ViewBag.NoResultsFound = true;
			}

			return data;
		}

		[AppAuthorize(AuthConst.AppOrder.UPDATE)]
		public async Task<IActionResult> CheckIn(int id)
		{
			try
			{
				// Lấy thông tin chi tiết hóa đơn
				var oDetail = await _repository.FindAsync<AppOrderDetail>(id);
				if (oDetail == null)
				{
					SetErrorMesg("Không tìm thấy chi tiết hóa đơn này!");
					return RedirectToAction(nameof(Index));
				}

				// Lấy thông tin hóa đơn
				var order = await _repository.GetOneAsync<AppOrder>(o => o.OrderDetails.Any(d => d.Id == oDetail.Id));
				if (order == null)
				{
					SetErrorMesg("Không tìm thấy hóa đơn tương ứng!");
					return RedirectToAction(nameof(Index));
				}

				// Lấy thông tin phòng
				var room = await _repository.GetOneAsync<AppRoom>(r => r.Id == oDetail.RoomId);
				if (room == null)
				{
					SetErrorMesg("Không tìm thấy phòng tương ứng!");
					return RedirectToAction(nameof(Index));
				}

				var user = CurrentUserId;

				if (DateTime.Now < oDetail.CheckInTime_Expected)
				{
					SetErrorMesg($"Không được nhận phòng trước thời gian dự kiến!");
					return RedirectToAction(nameof(Index));
				}

				#region Cập nhật detail
				// Cập nhật detail				
				oDetail.CheckInTime = DateTime.Now;
				oDetail.UpdatedDate = DateTime.Now;
				oDetail.UpdatedBy = user;
				await _repository.UpdateAsync<AppOrderDetail>(oDetail);
				#endregion

				#region Cập nhật order
				// Cập nhật order
				order.UpdatedDate = DateTime.Now;
				order.UpdatedBy = user;
				await _repository.UpdateAsync<AppOrder>(order);
				#endregion

				#region Cập nhật trạng thái phòng
				// Cập nhật trạng thái phòng
				room.Status = DB.RoomStatus.STATUS_CHECKIN_NAME;
				room.UpdatedBy = user;
				room.UpdatedDate = DateTime.Now;
				await _repository.UpdateAsync<AppRoom>(room);
				#endregion

				SetSuccessMesg($"Nhận phòng thành công!");
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				SetErrorMesg($"Có lỗi trong quá trình xử lý!");
				return RedirectToAction(nameof(Index));
			}
		}

		[AppAuthorize(AuthConst.AppOrder.UPDATE)]
		public async Task<IActionResult> CheckOut(int id)
		{
			try
			{
				var user = CurrentUserId;
				var now = DateTime.Now;

				// Lấy thông tin chi tiết hóa đơn
				var oDetail = await _repository.FindAsync<AppOrderDetail>(id);
				if (oDetail == null)
				{
					SetErrorMesg("Không tìm thấy chi tiết hóa đơn này!");
					return RedirectToAction(nameof(Index));
				}

				// Lấy thông tin phòng
				var room = await _repository.GetOneAsync<AppRoom>(r => r.Id == oDetail.RoomId);
				if (room == null)
				{
					SetErrorMesg("Không tìm thấy phòng tương ứng!");
					return RedirectToAction(nameof(Index));
				}

				#region Cập nhật trạng thái phòng
				// Cập nhật trạng thái phòng
				room.Status = DB.RoomStatus.STATUS_CHECKOUT_NAME;
				room.UpdatedBy = user;
				room.UpdatedDate = now;
				await _repository.UpdateAsync<AppRoom>(room);
				#endregion

				#region Tính giá cuối cùng của phòng
				// Tính giá cuối cùng của phòng
				var price = room.Price;
				var d1 = room.DiscountFrom ?? DateTime.MinValue;
				var d2 = room.DiscountTo ?? DateTime.MaxValue;
				if (room.DiscountPrice.HasValue && now.IsBetween(d1, d2))
				{
					price = room.DiscountPrice.Value;
				}
				room.Price = price;
				#endregion

				#region Cập nhật detail
				// Cập nhật detail
				oDetail.CheckOutTime = now;

				int stayDays = 0;
				if (oDetail.CheckOutTime.HasValue && oDetail.CheckInTime.HasValue)
				{
					stayDays = (oDetail.CheckOutTime.Value - oDetail.CheckInTime.Value).Days;
				}
				oDetail.TimeStay = stayDays;

				oDetail.TotalPrice = CalculateTotalPrice(room.Price, oDetail.CheckInTime_Expected, oDetail.CheckInTime, oDetail.CheckOutTime_Expected, oDetail.CheckOutTime);

				oDetail.UpdatedDate = now;
				oDetail.UpdatedBy = user;
				await _repository.UpdateAsync<AppOrderDetail>(oDetail);
				#endregion

				#region Cập nhật order
				// Lấy thông tin hóa đơn
				var order = await _repository.DbContext.AppOrders
										.Include(o => o.OrderDetails)
											.ThenInclude(d => d.Room)
										.FirstOrDefaultAsync(o => o.OrderDetails.Any(d => d.Id == oDetail.Id));
				if (order == null)
				{
					SetErrorMesg("Không tìm thấy hóa đơn tương ứng!");
					return RedirectToAction(nameof(Index));
				}

				// Check if all order details are checked out
				var allCheckedOut = order.OrderDetails.All(d => d.CheckOutTime.HasValue);
				if (allCheckedOut)
				{
					// Cập nhật order
					order.Status = DB.OrderStatus.STATUS_DONE_NAME;
					order.UpdatedDate = now;
					order.UpdatedBy = user;
					order.TotalPrice = order.OrderDetails.Sum(d => d.TotalPrice);
				}
				else
				{
					order.UpdatedDate = now;
					order.UpdatedBy = user;
					order.TotalPrice = order.OrderDetails.Sum(d => d.TotalPrice);
				}
				await _repository.UpdateAsync<AppOrder>(order);
				#endregion

				SetSuccessMesg($"Trả phòng thành công!");
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				SetErrorMesg($"Có lỗi trong quá trình xử lý!");
				return RedirectToAction(nameof(Index));
			}
		}

		[AppAuthorize(AuthConst.AppOrder.DELETE)]
		public async Task<IActionResult> CancelODetail(int id)
		{
			var user = CurrentUserId;

			var oDetail = await _repository.FindAsync<AppOrderDetail>(id);

			if (oDetail == null)
			{
				SetErrorMesg("Chi tiết hóa đơn này không tồn tại, hoặc bị xóa trước đó");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (oDetail.CheckInTime.HasValue)
			{
				SetErrorMesg("Không thể hủy chi tiết hóa đơn đã nhận phòng");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}
			if (oDetail.CheckOutTime.HasValue)
			{
				SetErrorMesg("Không thể hủy chi tiết hóa đơn đã trả phòng");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}

			#region Cập nhật trạng thái phòng
			// Lấy thông tin phòng
			var room = await _repository.GetOneAsync<AppRoom>(r => r.Id == oDetail.RoomId);
			if (room == null)
			{
				SetErrorMesg("Không tìm thấy phòng tương ứng!");
				return RedirectToAction(nameof(Index));
			}

			room.Status = DB.RoomStatus.STATUS_CANCELED_NAME;
			room.UpdatedBy = CurrentUserId;
			room.UpdatedDate = DateTime.Now;
			await _repository.UpdateAsync<AppRoom>(room);
			#endregion

			// Gỡ khóa ngoại
			oDetail.RoomId = null;
			// Xóa chi tiết hóa đơn
			await _repository.DeleteAsync(oDetail);

			#region Cập nhật order
			// Lấy thông tin hóa đơn
			var order = await _repository.DbContext.AppOrders
									.Include(o => o.OrderDetails)
										.ThenInclude(d => d.Room)
									.FirstOrDefaultAsync(o => o.OrderDetails.Any(d => d.Id == oDetail.Id));
			if (order == null)
			{
				SetErrorMesg("Không tìm thấy hóa đơn tương ứng!");
				return RedirectToAction(nameof(Index));
			}
			// Check if all order details are checked out
			var allCheckedOut = order.OrderDetails.All(d => d.DeletedDate.HasValue);
			if (allCheckedOut)
			{
				// Cập nhật order
				order.Status = DB.OrderStatus.STATUS_CANCEL_NAME;
				order.UpdatedDate = DateTime.Now;
				order.UpdatedBy = user;
				order.QuantityRoom--;
			}
			else
			{
				order.UpdatedDate = DateTime.Now;
				order.UpdatedBy = user;
				order.QuantityRoom--;
			}

			oDetail.OrderId = null;
			await _repository.UpdateAsync(oDetail);
			await _repository.UpdateAsync(order);
			#endregion

			SetSuccessMesg($"Thông tin đặt phòng '{oDetail.RoomName}' được xóa thành công");
			if (Referer != null)
			{
				return Redirect(Referer);
			}
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}

		[AppAuthorize(AuthConst.AppOrder.DELETE)]
		public async Task<IActionResult> DeleteOrder(int id)
		{
			var user = CurrentUserId;

			var order = await _repository.FindAsync<AppOrder>(id);

			if (order == null)
			{
				SetErrorMesg("Chi tiết hóa đơn này không tồn tại, hoặc bị xóa trước đó");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}

			if (order.QuantityRoom == 0 && order.Status == DB.OrderStatus.STATUS_CANCEL_NAME)
			{
				await _repository.DeleteAsync(order);
			}
			else
			{
				SetErrorMesg("Không thể xóa đơn hàng trong khi vẫn còn thông tin đặt phòng!");
				return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
			}

			SetSuccessMesg($"Thông tin đặt phòng của '{order.CusName}' được xóa thành công");
			if (Referer != null)
			{
				return Redirect(Referer);
			}
			return RedirectToAction(nameof(Index), ROUTE_FOR_AREA);
		}

		private static decimal CalculateTotalPrice(decimal roomPrice, DateTime checkInTimeExpected, DateTime? checkInTime, DateTime checkOutTimeExpected, DateTime? checkOutTimeActual)
		{
			int stayDays = 0;

			if (checkOutTimeActual.HasValue && checkInTime.HasValue)
			{
				stayDays = (checkOutTimeActual.HasValue
							? (checkOutTimeActual.Value - checkInTime.Value).Days
							: (checkOutTimeExpected - checkInTime.Value).Days);
			}

			if (checkInTimeExpected != DateTime.MinValue && checkOutTimeExpected != DateTime.MinValue)
			{
				stayDays = (checkOutTimeExpected - checkInTimeExpected).Days;
			}

			decimal totalPrice = roomPrice * stayDays;

			if (checkOutTimeActual.HasValue && checkOutTimeActual.Value > checkOutTimeExpected)
			{
				TimeSpan lateStay = checkOutTimeActual.Value - checkOutTimeExpected;
				if (lateStay.TotalHours > 6)
				{
					totalPrice += roomPrice;
				}
				else if (lateStay.TotalHours > 3)
				{
					totalPrice += (roomPrice * 0.5m);
				}
				else if (lateStay.TotalHours > 1)
				{
					totalPrice += (roomPrice * 0.3m);
				}
			}

			if (checkOutTimeActual.HasValue && checkOutTimeActual.Value < checkOutTimeExpected)
			{
				TimeSpan earlyStay = checkOutTimeExpected - checkOutTimeActual.Value;
				if (earlyStay.TotalHours > 3)
				{
					totalPrice -= (roomPrice * 0.5m);
				}
				else if (earlyStay.TotalHours > 1)
				{
					totalPrice -= (roomPrice * 0.3m);
				}
			}

			return totalPrice;
		}

	}
}