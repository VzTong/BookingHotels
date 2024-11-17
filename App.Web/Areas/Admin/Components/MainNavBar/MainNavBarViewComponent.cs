using App.Data.Repositories;
using App.Share.Consts;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Areas.Admin.Components.MainNavBar
{
	public class MainNavBarViewComponent : ViewComponent
	{
		readonly GenericRepository repository;
		public MainNavBarViewComponent(GenericRepository _repository)
		{
			repository = _repository;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var navBar = new NavBarViewModel();
			navBar.Items.AddRange(new MenuItem[]
			{
				new MenuItem
				{
					Action = "Index",
					Controller = "Home",
					DisplayText = "Bảng tổng quan",
					Icon = "tachometer-alt",
					Permission = AuthConst.NO_PERMISSION
				},
				new MenuItem
				{
					DisplayText = "Khách sạn",
                    SidebarText = "Hotels",
					DataKey = "hotels",
                    Icon = "hotel",
					ChildrenItems = new MenuItem[]
					{
						new MenuItem
						{
							Action = "Index",
							Controller = "AppBranchHotel",
							DataKey = "branch-hotels",
							DisplayText = "Chi nhánh",
							Permission = AuthConst.AppBranchHotel.VIEW_LIST
						},
						new MenuItem
						{
							Action = "Index",
							Controller = "AppHotel",
							DataKey = "hotels",
							DisplayText = "Khách sạn",
							Permission = AuthConst.AppHotel.VIEW_LIST
						}
					}
				},
				new MenuItem
				{
					DisplayText = "Phòng",
					SidebarText = "Room",
					DataKey = "mg-rooms",
					Icon = "bed",
					ChildrenItems = new MenuItem[]
					{
						new MenuItem
						{
							Action = "Index",
							Controller = "AppRoomType",
							DataKey = "room-types",
							DisplayText = "Loại phòng",
							Permission = AuthConst.AppRoomType.VIEW_LIST
						},
						new MenuItem
						{
							Action = "Index",
							Controller = "AppRoom",
							DataKey = "rooms",
							DisplayText = "Phòng",
							Permission = AuthConst.AppRoom.VIEW_LIST
						}
					}
				},
				new MenuItem
				{
					DisplayText = "Trang thiết bị",
					SidebarText = "Equipment",
					DataKey = "equipments",
					Icon = "toolbox",
					ChildrenItems = new MenuItem[]
					{
						new MenuItem
						{
							Action = "Index",
							Controller = "AppEType",
							DataKey = "type-equipments",
							DisplayText = "Loại trang thiết bị",
							Permission = AuthConst.AppEquipmentType.VIEW_LIST
						},
						new MenuItem
						{
							Action = "Index",
							Controller = "AppEquipment",
							DataKey = "equipments",
							DisplayText = "Trang thiết bị",
							Permission = AuthConst.AppEquipment.VIEW_LIST
						}
					}
				},
				new MenuItem
				{
					DisplayText = "Quản lý tin tức",
					SidebarText = "News",
					DataKey = "mg-news",
					Icon = "newspaper",
					ChildrenItems = new MenuItem[]
					{
						new MenuItem
						{
							Action = "Index",
							Controller = "AppNewsCategory",
							DataKey = "category-news",
							DisplayText = "Quản lý thể loại tin",
							Permission = AuthConst.AppCategoryNews.VIEW_LIST
						},
						new MenuItem
						{
							Action = "Index",
							Controller = "AppNews",
							DataKey = "news",
							DisplayText = "Quản lý bài viết",
							Permission = AuthConst.AppNews.VIEW_LIST
						}
					}
				},
				new MenuItem
				{
					DisplayText = "Nhân viên",
					SidebarText = "Employee",
					Icon = "suitcase",
					DataKey = "employee",
					ChildrenItems=new MenuItem[]
					{
						new MenuItem
						{
							Action = "Index",
							Controller = "AppWorkSchedule",
							DataKey = "work-schedules",
							DisplayText = "Lịch làm",
							Permission = AuthConst.AppWorkSchedule.VIEW_LIST,
						},
						new MenuItem
						{
							Action = "Index",
							Controller = "AppPayRoll",
							DataKey = "pay-rolls",
							DisplayText = "Bảng lương",
							Permission = AuthConst.AppPayroll.VIEW_LIST,
						}
					}
				},
				new MenuItem
				{
					DisplayText = "Tài khoản",
					Icon = "id-card",
					DataKey = "account",
					ChildrenItems=new MenuItem[]
					{
						new MenuItem
						{
							Action = "Index",
							Controller = "AppRole",
							DataKey = "roles",
							DisplayText = "Vai trò trên trang",
							Permission = AuthConst.AppRole.VIEW_LIST,
						},
						new MenuItem
						{
							Action = "Index",
							Controller = "User",
							DataKey = "users",
							DisplayText = "Quản lý tài khoản",
							Permission = AuthConst.AppUser.VIEW_LIST,
						}
					}
				},
				new MenuItem
				{
					Action = "Index",
					Controller = "FileManager",
					DisplayText = "Quản lý tệp",
					Icon = "folder-open",
				},
				new MenuItem
				{
					Action = "Index",
					Controller = "AppOrder",
					DisplayText = "Quản lý đặt phòng",
					Icon = "mug-hot",
					Permission = AuthConst.AppOrder.VIEW_LIST
				},
			});
			return View(navBar);
		}
	}
}