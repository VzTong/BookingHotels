﻿using App.Data.Configurations;
using App.Data.Configurations.Hotel;
using App.Data.Configurations.Room;
using App.Data.Configurations.User;
using App.Data.Configurations.User.Staff;
using App.Data.Configurations.WebService;
using App.Data.DataSeeders;
using App.Data.Entities.Hotel;
using App.Data.Entities.News;
using App.Data.Entities.Room;
using App.Data.Entities.service;
using App.Data.Entities.User;
using App.Data.Entities.User.Staff;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
	public class WebAppDbContext : DbContext
	{
		public DbSet<AppBranchHotel> AppBranchHotels { get; set; }
		public DbSet<AppHotel> AppHotels { get; set; }
		public DbSet<AppEquipment> AppEquipment { get; set; }
		public DbSet<AppEquipmentType> AppEquipmentTypes { get; set; }
		public DbSet<AppImgRoom> AppImgRooms { get; set; }
		public DbSet<AppRoom> AppRooms { get; set; }
		public DbSet<AppRoomEquipment> AppRoomEquipments { get; set; }
		public DbSet<AppRoomType> AppRoomTypes { get; set; }
		public DbSet<AppPayroll> AppPayrolls { get; set; }
		public DbSet<AppWorkSchedule> AppWorkSchedules { get; set; }
		public DbSet<AppWorkShift> AppWorkShifts { get; set; }
		public DbSet<AppRole> AppRole { get; set; }
		public DbSet<AppRolePermission> AppRolePermission { get; set; }
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<MstPermission> MstPermissions { get; set; }
		public DbSet<AppComment> AppComments { get; set; }
		public DbSet<AppNews> AppNews { get; set; }
		public DbSet<AppNewsCategory> AppNewsCategories { get; set; }
		public DbSet<AppOrder> AppOrders { get; set; }
		public DbSet<AppOrderDetail> AppOrderDetail { get; set; }

		public WebAppDbContext(DbContextOptions<WebAppDbContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.ApplyConfiguration(new AppBranchHotelConfig());
            modelBuilder.ApplyConfiguration(new AppHotelConfig());
            modelBuilder.ApplyConfiguration(new AppEquipmentConfig());
            modelBuilder.ApplyConfiguration(new AppEquipmentTypeConfig());
            modelBuilder.ApplyConfiguration(new AppImgRoomConfig());
            modelBuilder.ApplyConfiguration(new AppRoomConfig());
            modelBuilder.ApplyConfiguration(new AppRoomEquipmentConfig());
            modelBuilder.ApplyConfiguration(new AppRoomTypeConfig());
            modelBuilder.ApplyConfiguration(new AppPayrollConfig());
            modelBuilder.ApplyConfiguration(new AppWorkScheduleConfig());
            modelBuilder.ApplyConfiguration(new AppWorkShiftConfig());
            modelBuilder.ApplyConfiguration(new AppRoleConfig());
            modelBuilder.ApplyConfiguration(new AppRolePermissionConfig());
            modelBuilder.ApplyConfiguration(new AppUserConfig());
            modelBuilder.ApplyConfiguration(new MstPermissionConfig());
            modelBuilder.ApplyConfiguration(new AppNewsCategoryConfig());
            modelBuilder.ApplyConfiguration(new AppCommentConfig());
            modelBuilder.ApplyConfiguration(new AppNewsConfig());
            modelBuilder.ApplyConfiguration(new AppOrderConfig());
            modelBuilder.ApplyConfiguration(new AppOrderDetailConfig());

            // Tạo dữ liệu
            modelBuilder.Entity<AppHotel>().SeedData();
            modelBuilder.Entity<AppBranchHotel>().SeedData();
            modelBuilder.Entity<MstPermission>().SeedData();
            modelBuilder.Entity<AppRole>().SeedData();
            modelBuilder.Entity<AppRolePermission>().SeedData();
            modelBuilder.Entity<AppUser>().SeedData();
            modelBuilder.Entity<AppEquipmentType>().SeedData();
            modelBuilder.Entity<AppEquipment>().SeedData();
            modelBuilder.Entity<AppRoomType>().SeedData();
            modelBuilder.Entity<AppNewsCategory>().SeedData();
            modelBuilder.Entity<AppNews>().SeedData();
            modelBuilder.Entity<AppRoom>().SeedData();
            modelBuilder.Entity<AppImgRoom>().SeedData();
            modelBuilder.Entity<AppRoomEquipment>().SeedData();
            modelBuilder.Entity<AppComment>().SeedData();
            modelBuilder.Entity<AppOrder>().SeedData();
            modelBuilder.Entity<AppOrderDetail>().SeedData();
        }
	}
}