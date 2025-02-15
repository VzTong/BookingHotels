﻿using App.Data.Entities.Room;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class AppRoomSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppRoom> builder)
		{
			var now = new DateTime(year: 2024, month: 10, day: 10);

			builder.HasData(
				new AppRoom
				{
					Id = 1,
					RoomName = "T0145•101 Luxury",
					FloorNumber = 145,
					RoomNumber = 101,
					Slug = "t0145-101-luxury",
					Status = DB.RoomStatus.STATUS_CHECKOUT_NAME,
					Price = 15000000,
					DiscountPrice = 12000000,
					DiscountFrom = new DateTime(2024, 10, 1),
					DiscountTo = new DateTime(2024, 12, 31),
					CreatedDate = new DateTime(2023, 10, 1),
					IsActive = true,
					BranchId = 10,
					RoomTypeId = DB.AppRoomTypeName.LUXURY_ROOM_ID,
				},
				new AppRoom
				{
					Id = 2,
					RoomName = "T012•205 Double",
					FloorNumber = 12,
					RoomNumber = 205,
					Slug = "t012-205-double",
					Status = DB.RoomStatus.STATUS_BOOKING_NAME,
					Price = 1200000,
					CreatedDate = now,
					IsActive = true,
					BranchId = 2,
					RoomTypeId = DB.AppRoomTypeName.DOUBLE_ROOM_ID,
				},
				new AppRoom
				{
					Id = 3,
					RoomName = "T02•15 Double",
					FloorNumber = 2,
					RoomNumber = 15,
					Slug = "t012-205-double",
					Status = DB.RoomStatus.STATUS_BOOKING_NAME,
					Price = 120000,
					CreatedDate = new DateTime(2023, 10, 15),
					IsActive = true,
					BranchId = 1,
					RoomTypeId = DB.AppRoomTypeName.DOUBLE_ROOM_ID,
				},
				new AppRoom
				{
					Id = 4,
					RoomName = "T03•101 Single",
					FloorNumber = 3,
					RoomNumber = 101,
					Slug = "t03-101-single",
					Status = DB.RoomStatus.STATUS_PENDING_NAME,
					Price = 8000000,
					CreatedDate = now,
					IsActive = true,
					BranchId = 13,
					RoomTypeId = DB.AppRoomTypeName.SINGLE_ROOM_ID,
				},
				new AppRoom
				{
					Id = 5,
					RoomName = "T04•102 Single",
					FloorNumber = 4,
					RoomNumber = 102,
					Slug = "t04-102-single",
					Status = DB.RoomStatus.STATUS_PENDING_NAME,
					Price = 80000,
					CreatedDate = new DateTime(2024, 3, 15),
					IsActive = true,
					BranchId = 3,
					RoomTypeId = DB.AppRoomTypeName.SINGLE_ROOM_ID,
				},
				new AppRoom
				{
					Id = 6,
					RoomName = "T05•201 Family",
					FloorNumber = 5,
					RoomNumber = 201,
					Slug = "t05-201-family",
					Status = DB.RoomStatus.STATUS_PROCESSING_NAME,
					Price = 200000,
					CreatedDate = new DateTime(2022, 10, 15),
					IsActive = true,
					BranchId = 7,
					RoomTypeId = DB.AppRoomTypeName.FAMILY_ROOM_ID,
				},
				new AppRoom
				{
					Id = 7,
					RoomName = "T06•202 Family",
					FloorNumber = 6,
					RoomNumber = 202,
					Slug = "t06-202-family",
					Status = DB.RoomStatus.STATUS_BOOKING_NAME,
					Price = 200000,
					CreatedDate = new DateTime(2024, 10, 15),
					IsActive = true,
					BranchId = 1,
					RoomTypeId = DB.AppRoomTypeName.FAMILY_ROOM_ID,
				},
				new AppRoom
				{
					Id = 8,
					RoomName = "T07•301 VIP",
					FloorNumber = 7,
					RoomNumber = 301,
					Slug = "t07-301-vip",
					Status = DB.RoomStatus.STATUS_CHECKIN_NAME,
					Price = 20000000, // Adjusted price for VIP room
					CreatedDate = new DateTime(2024, 10, 15),
					IsActive = true,
					BranchId = 1,
					RoomTypeId = DB.AppRoomTypeName.VIP_ROOM_ID,
				},
				new AppRoom
				{
					Id = 9,
					RoomName = "T08•302 VIP",
					FloorNumber = 8,
					RoomNumber = 302,
					Slug = "t08-302-vip",
					Status = DB.RoomStatus.STATUS_CHECKIN_NAME,
					Price = 20000000, // Adjusted price for VIP room
					CreatedDate = now,
					IsActive = true,
					BranchId = 23,
					RoomTypeId = DB.AppRoomTypeName.VIP_ROOM_ID,
				},
				new AppRoom
				{
					Id = 10,
					RoomName = "T09•401 Luxury",
					FloorNumber = 9,
					RoomNumber = 401,
					Slug = "t09-401-luxury",
					Status = DB.RoomStatus.STATUS_CANCELED_NAME,
					Price = 15000000,
					CreatedDate = now,
					IsActive = true,
					BranchId = 23,
					RoomTypeId = DB.AppRoomTypeName.LUXURY_ROOM_ID,
				},
				new AppRoom
				{
					Id = 11,
					RoomName = "T10•402 Luxury",
					FloorNumber = 10,
					RoomNumber = 402,
					Slug = "t10-402-luxury",
					Status = DB.RoomStatus.STATUS_CANCELED_NAME,
					Price = 15000000,
					CreatedDate = now,
					IsActive = true,
					BranchId = 15,
					RoomTypeId = DB.AppRoomTypeName.LUXURY_ROOM_ID,
				},
				// Adding rooms with discounts
				new AppRoom
				{
					Id = 12,
					RoomName = "T11•501 VIP",
					FloorNumber = 11,
					RoomNumber = 501,
					Slug = "t11-501-vip",
					Status = DB.RoomStatus.STATUS_CHECKIN_NAME,
					Price = 20000000,
					DiscountPrice = 18000000,
					DiscountFrom = new DateTime(2024, 11, 1),
					DiscountTo = new DateTime(2024, 12, 31),
					CreatedDate = new DateTime(2024, 7, 15),
					IsActive = true,
					BranchId = 1,
					RoomTypeId = DB.AppRoomTypeName.VIP_ROOM_ID,
				},
				new AppRoom
				{
					Id = 13,
					RoomName = "T12•502 Luxury",
					FloorNumber = 12,
					RoomNumber = 502,
					Slug = "t12-502-luxury",
					Status = DB.RoomStatus.STATUS_CHECKOUT_NAME,
					Price = 15000000,
					DiscountPrice = 14000000,
					DiscountFrom = new DateTime(2024, 11, 1),
					DiscountTo = new DateTime(2024, 12, 31),
					CreatedDate = now,
					IsActive = true,
					BranchId = 2,
					RoomTypeId = DB.AppRoomTypeName.LUXURY_ROOM_ID,
				}
			);
		}
	}
}