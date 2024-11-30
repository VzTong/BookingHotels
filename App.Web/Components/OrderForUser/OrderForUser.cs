using App.Data.Entities.service;
using App.Data.Repositories;
using App.Web.ViewModels.Order;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace App.Web.Components.OrderForUser
{
	public class OrderForUser : ViewComponent
	{
		readonly GenericRepository repository;
		public OrderForUser(GenericRepository _db)
		{
			repository = _db;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var user = CurrentUserId;

			var data = await repository.GetAll<AppOrder>(x => x.DeletedDate == null && x.CustomerId == user)
				.Include(s => s.OrderDetails)
				.ThenInclude(s => s.Room)
				.OrderBy(x => x.DisplayOrder)
				.Select(x => new OrderVM
				{
					Id = x.Id,
					TotalAmount = x.TotalPrice,
					QuantityRoom = x.QuantityRoom,
					Status = x.Status,
					AppOrderDetails = x.OrderDetails.Select(s => new OrderDetailVM
					{
						Id = s.Id,
						OrderId = s.OrderId,
						RoomName = s.RoomName,
						RoomStatus = s.Room.Status,
						TotalPrice = s.TotalPrice,
						CheckInTime_Expected = s.CheckInTime_Expected,
						CheckOutTime_Expected = s.CheckOutTime_Expected,
						CheckInTime = s.CheckInTime,
						CheckOutTime = s.CheckOutTime,
						TimeStay = s.TimeStay
					}).ToList()
				})
				.ToListAsync();
			return View(data);
		}
		protected int CurrentUserId { get => Convert.ToInt32(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)); }
	}
}