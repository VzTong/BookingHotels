﻿using App.Data.Entities.Room;
using App.Data.Entities.service;
using App.Data.Entities.User;
using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Common;
using App.Web.ViewModels.Order;
using App.Web.WebConfig;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace App.Web.Controllers
{
	public class OrderController : AppControllerBase
	{
		private readonly INotyfService _notyf;
		private readonly IHttpContextAccessor _contextAccessor;

		public OrderController(IMapper mapper, GenericRepository repo, INotyfService notyf, IHttpContextAccessor contextAccessor) : base(mapper, repo)
		{
			_notyf = notyf;
			_contextAccessor = contextAccessor;
		}

		public async Task<IActionResult> Index()
		{
			var carts = await GetCartFromCustomer();

			// Tạo thông tin đặt hàng nếu đã đăng nhập
			if (User.Identity.IsAuthenticated)
			{
				var userId = CurrentUserId;
				var cusData = await _repository.GetOneAsync<AppUser>(x => x.Id == userId);
				var orderData = new OrderDataVM
				{
					CusEmail = cusData.Email,
					CusName = cusData.FullName,
					CusPhone = cusData.PhoneNumber1,
					CusCitizenId = cusData.CitizenId,
					CusPassport = cusData.Passport,
					CusPermanent = cusData.Permanent,
					CusNote = ""
				};
				ViewBag.CusData = orderData;
			}
			return View(carts);
		}

		// Tạo thông tin đơn hàng
		[HttpPost]
		[AppAuthorize]
		public async Task<IActionResult> Order(OrderDataVM model)
		{
			if (!ModelState.IsValid)
			{
				_notyf.Error("Dữ liệu không hợp lệ, vui lòng kiểm tra lại", 10);
				return RedirectToAction(nameof(Index));
			}
			await AddDataToOrder(model);
			RemoveAllCartData();
			_notyf.Success("Đơn đặt hàng đã được gửi thành công!", 10);
			return RedirectToAction("Index", "Home");
		}

		private async Task AddDataToOrder(OrderDataVM model)
		{
			model.Status = DB.OrderStatus.STATUS_PROCESSING_NAME;
			model.CusNote = model.CusNote ?? string.Empty; // Ensure CusNote is not null
			var order = new AppOrder();
			_mapper.Map(model, order);
			var orderDetail = await GetCartFromCustomer();
			foreach (var detail in orderDetail)
			{
				var tmp = new AppOrderDetail
				{
					RoomId = detail.Id,
					RoomName = detail.RoomName,
					TotalPrice = detail.TotalPrice,
					CheckInTime_Expected = model.CheckInTime_Expected,
					CheckOutTime_Expected = model.CheckOutTime_Expected,
					CreatedBy = CurrentUserId,
					CreatedDate = DateTime.Now
				};
				order.QuantityRoom++;
				order.TotalPrice += tmp.TotalPrice;
				order.OrderDetails.Add(tmp);
				order.CustomerId = CurrentUserId;
				// Update room status to booked
				var room = await _repository.FindAsync<AppRoom>(detail.Id);
				if (room != null)
				{
					room.Status = DB.RoomStatus.STATUS_BOOKING_NAME;
					await _repository.UpdateAsync(room);
				}
			}
			await _repository.AddAsync(order);
		}

		private async Task<List<CartItemVM>> GetCartFromCustomer()
		{
			//Lấy cookie
			String[] cookie = Request.Cookies.Keys.Where(c => c.IndexOf("sp_") == 0).ToArray();
			List<CartItemVM> cartItems = new List<CartItemVM>();
			foreach (var item in cookie)
			{
				cartItems.Add(new CartItemVM
				{
					Id = Convert.ToInt32(item.Split('_')[1])
				});
			}

			// Get dữ liệu sản phẩm dựa vào cookie giỏ hàng
			var productIds = cartItems.Select(x => x.Id).ToList();
			var data = await _repository.GetAll<AppRoom, CartItemVM>(
							AutoMapperProfile.CartConf,
							false,
							where: x => productIds.Contains(x.Id) && x.IsActive)
						.ToListAsync();

			// .Xóa sản phẩm không khả dụng (bị xóa hoặc có IsActive == false) đã được thêm vào giỏ hàng trước đó
			var invalidIds = productIds.Where(x => !data.Select(x => x.Id).ToList().Contains(x)).ToList();
			foreach (var x in invalidIds)
			{
				Response.Cookies.Delete("sp_" + x);
			}
			return data ?? new List<CartItemVM>();
		}

		private void RemoveAllCartData()
		{
			String[] cookie = Request.Cookies.Keys.Where(c => c.IndexOf("sp_") == 0).ToArray();
			foreach (var item in cookie)
			{
				Response.Cookies.Delete(item);
			}
		}

		public async Task<IActionResult> CancelODetailClient(int id)
		{
			var user = CurrentUserId;

			var oDetail = await _repository.GetOneAsync<AppOrderDetail>(x => x.Id == id);
			if (oDetail == null)
			{
				SetErrorMesg("Chi tiết hóa đơn này không tồn tại, hoặc bị xóa trước đó");
				return RedirectToAction("Index", "Home");
			}
			if (oDetail.CheckInTime.HasValue)
			{
				SetErrorMesg("Không thể hủy chi tiết hóa đơn đã nhận phòng");
				return RedirectToAction("Index", "Home");
			}
			if (oDetail.CheckOutTime.HasValue)
			{
				SetErrorMesg("Không thể hủy chi tiết hóa đơn đã trả phòng");
				return RedirectToAction("Index", "Home");
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
			var allCheckedOut = order.OrderDetails.All(d => d.CheckOutTime.HasValue);
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
			// GỠ khóa ngoại
			oDetail.OrderId = null;
			await _repository.UpdateAsync(oDetail);
			await _repository.UpdateAsync<AppOrder>(order);
			#endregion

			SetSuccessMesg($"Thông tin đặt phòng '{oDetail.RoomName}' được xóa thành công");
			return RedirectToAction("Index", "Home");
		}
	}
}