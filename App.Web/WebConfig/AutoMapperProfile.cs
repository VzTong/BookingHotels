using App.Data.Entities.Hotel;
using App.Data.Entities.News;
using App.Data.Entities.Room;
using App.Data.Entities.service;
using App.Data.Entities.User;
using App.Web.Areas.Admin.ViewModels.Account;
using App.Web.Areas.Admin.ViewModels.BranchHotel;
using App.Web.Areas.Admin.ViewModels.CategoryNews;
using App.Web.Areas.Admin.ViewModels.Equipment;
using App.Web.Areas.Admin.ViewModels.EquipmentType;
using App.Web.Areas.Admin.ViewModels.Hotel;
using App.Web.Areas.Admin.ViewModels.News;
using App.Web.Areas.Admin.ViewModels.Order;
using App.Web.Areas.Admin.ViewModels.Role;
using App.Web.Areas.Admin.ViewModels.Room;
using App.Web.Areas.Admin.ViewModels.RoomType;
using App.Web.Areas.Admin.ViewModels.User;
using App.Web.ViewModels.Account;
using App.Web.ViewModels.News;
using App.Web.ViewModels.Order;
using App.Web.ViewModels.Room;
using AutoMapper;

namespace App.Web.WebConfig
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			// Map dữ liệu từ kiểu UserAddOrEditVM sang AppUser
			CreateMap<UserAddOrEditVM, AppUser>();

			// Map dữ liệu từ kiểu AppUser sang UserAddOrEditVM
			CreateMap<AppUser, UserAddOrEditVM>();
			CreateMap<AppUser, UpdateUserViewModel>().ReverseMap();
			CreateMap<AppUser, UserDataForApp>().ReverseMap();
			CreateMap<AppUser, AcceptUpdateViewModel>().ReverseMap();
			CreateMap<AppUser, UserRegisterVM>().ReverseMap();
			CreateMap<AppUser, UserProfileClientVM>().ReverseMap();

			// Map dữ liệu của AppHotel
			CreateMap<AppHotel, AddOrUpdateHotelVM>().ReverseMap();

			// Map dữ liệu của AppBranchHotel
			CreateMap<AppBranchHotel, AddOrUpdateBranchHotelVM>().ReverseMap();

			// Map dữ liệu của AppEquipment
			CreateMap<AppEquipment, AddOrUpdateEquipmentVM>().ReverseMap();

			// Map dữ liệu của AppEquipmentType
			CreateMap<AppEquipmentType, AddOrUpdateETypeVM>().ReverseMap();

			// Map dữ liệu của AppNewsCategory
			CreateMap<AppNewsCategory, AddOrUpdateCategoryNewsVM>().ReverseMap();

			// Map dữ liệu của AppNews
			CreateMap<AppNews, AddOrUpdateNewsVM>().ReverseMap();
			CreateMap<AppNews, NewsVM>()
			.ForMember(AppNews => AppNews.CreatedByName, opts => 
				opts.MapFrom(AppNews => AppNews.Users.Id == AppNews.CreatedBy ? "khong co j" : AppNews.Users.FullName ))
				.ReverseMap();

			// Map dữ liệu của AppRoomType
			CreateMap<AppRoomType, AddOrUpdateRTypeVM>().ReverseMap();

			// Map dữ liệu của AppRoom
			CreateMap<AppRoom, AddOrUpdateRoomVM>()
			.ForMember(dest => dest.ImgRooms, opt => opt.MapFrom(src => src.ImgRooms))
			.ForMember(dest => dest.EquipmentId, opt => opt.MapFrom(src => src.RoomEquipments.Select(e => e.EquipmentId)))
			.ForMember(dest => dest.LinkImage1_path, opt => opt.MapFrom(src => src.ImgRooms.ElementAtOrDefault(0).ImgSrc))
			.ForMember(dest => dest.LinkImage2_path, opt => opt.MapFrom(src => src.ImgRooms.ElementAtOrDefault(1).ImgSrc))
			.ForMember(dest => dest.LinkImage3_path, opt => opt.MapFrom(src => src.ImgRooms.ElementAtOrDefault(2).ImgSrc))
			.ForMember(dest => dest.LinkImage4_path, opt => opt.MapFrom(src => src.ImgRooms.ElementAtOrDefault(3).ImgSrc))
			.ReverseMap();

			// Cấu hình mapping cho RoomController, action Detail area Client
			CreateMap<AppRoom, RoomDetailVM>()
			.ForMember(dest => dest.ImagePath, opt => opt.MapFrom(src => src.ImgRooms.Select(img => img.ImgSrc).ToList()))
			.ForMember(dest => dest.EquipmentName, opt => opt.MapFrom(src => src.RoomEquipments.Select(e => e.Equipment.Name).ToList()))
			.ForMember(dest => dest.RoomTypeName, opt => opt.MapFrom(src => src.RoomType != null ? src.RoomType.RoomTypeName : string.Empty))
			.ForMember(dest => dest.BranchDesc, opt => opt.MapFrom(src => src.Branch != null ? src.Branch.Description : string.Empty))
			.ForMember(dest => dest.HotelName, opt => opt.MapFrom(src => src.Branch != null && src.Branch.Hotel != null ? src.Branch.Hotel.Name : string.Empty))
			.ForMember(dest => dest.PeopleStay, opt => opt.MapFrom(src => src.RoomType.PeopleStay))
			.ForMember(dest => dest.BringPet, opt => opt.MapFrom(src => src.RoomType != null && src.RoomType.BringPet));

			// Map dữ liệu của OrderDataVM
			CreateMap<OrderDataVM, AppOrder>().ReverseMap();
		}

		// Cấu hình mapping cho RoleController, action Index area Admin
		public static MapperConfiguration RoleIndexConf = new(mapper =>
		{
			// Map dữ liệu từ kiểu AppRole sang RoleListItemVM
			mapper.CreateMap<AppRole, RoleListItemVM>()
				.ForMember(
					uItem => uItem.BranchName,
					opts => opts.MapFrom(
						uEntity => uEntity.AppUsers
							.Select(b => b.Branch.Name)
							.First())
					);
		});

		// Cấu hình mapping cho UserController, action Index area Admin
		public static MapperConfiguration UserIndexConf = new(mapper =>
		{
			// Map dữ liệu từ AppUser sang UserListItemVM, map thuộc tính RoleName
			mapper.CreateMap<AppUser, UserListItemVM>()
				.ForMember(uItem => uItem.RoleName, opts => opts.MapFrom(uEntity => uEntity.AppRole.Name))
				.ForMember(uItem => uItem.BranchName, opts => opts.MapFrom(uEntity => uEntity.Branch.Name));
		});

		// Cấu hình mapping cho AccountController, action Login
		public static MapperConfiguration LoginConf = new(mapper =>
		{
			// Map dữ liệu từ AppUser sang UserListItemVM, map thuộc tính RoleName
			mapper.CreateMap<AppUser, UserDataForApp>()
				.ForMember(uItem => uItem.RoleName, opts => opts.MapFrom(uEntity => uEntity.AppRole == null ? "" : uEntity.AppRole.Name))
				.ForMember(uItem => uItem.Permission, opts => opts.MapFrom
				(
					uEntity => string.Join(',', uEntity.AppRole
														.AppRolePermissions
														.Select(p => p.MstPermissionId))
				)
			);
		});

		public static MapperConfiguration UpdateConf = new(mapper =>
		{
			// Map dữ liệu từ AppUser sang UserListItemVM, map thuộc tính RoleName
			mapper.CreateMap<AppUser, UpdateUserViewModel>()
				.ForMember(uItem => uItem.RoleName, opts => opts.MapFrom(uEntity => uEntity.AppRole == null ? "" : uEntity.AppRole.Name))
				.ForMember(uItem => uItem.Permission, opts => opts.MapFrom
				(
					uEntity => string.Join(',', uEntity.AppRole
														.AppRolePermissions
														.Select(p => p.MstPermissionId))
				)
			);
		});

		// Cấu hình mapping cho RoleController, action Delete
		public static MapperConfiguration RoleDeleteConf = new(mapper =>
		{
			// Map dữ liệu thuộc tính con
			mapper.CreateMap<AppUser, RoleDeleteVM_User>();
			// Map dữ liệu thuộc tính cha
			mapper.CreateMap<AppRole, RoleDeleteVM>();
		});

		// Cấu hình mapping cho AppBranchHotelController, action Index area Admin
		public static MapperConfiguration BranchHotelIndexConf = new(mapper =>
		{
			mapper.CreateMap<AppBranchHotel, AppBranchHotelListItemVM>()
				.ForMember(uItem => uItem.HotelName, opts => opts.MapFrom(uEntity => uEntity.Hotel.Name));
		});

		// Cấu hình mapping cho AppHotelController, action Index area Admin
		public static MapperConfiguration HotelIndexConf = new(mapper =>
		{
			// Map dữ liệu từ AppHotel sang HotelListItemVM, map thuộc tính TypeEquipmentName
			mapper.CreateMap<AppHotel, HotelListItemVM>()
				.ForMember(
					uItem => uItem.BranchName,
					opts => opts.MapFrom(
						uEntity => uEntity.BranchHotels
							.Select(bh => bh.Name)
							.ToList()
					)
				);
		});

		// Cấu hình mapping cho AppEquipmentController, action Index area Admin
		public static MapperConfiguration EquipmentIndexConf = new(mapper =>
		{
			// Map dữ liệu từ AppEquipment sang EquipmentListItemVM, map thuộc tính TypeEquipmentName
			mapper.CreateMap<AppEquipment, EquipmentListItemVM>()
				.ForMember(uItem => uItem.TypeEquipmentName, opts => opts.MapFrom(uEntity => uEntity.TypeEquipment.Name));
		});

		// Cấu hình mapping cho AppETypeController, action Index area Admin
		public static MapperConfiguration ETypeIndexConf = new(mapper =>
		{
			mapper.CreateMap<AppEquipmentType, ETypeListItemVM>()
				.ForMember(
					uItem => uItem.EquipmentName,
					opts => opts.MapFrom(
						uEntity => uEntity.Equipments
							.Select(e => e.Name)
							.ToList()
					)
				);
		});

		// Cấu hình mapping cho AppNewsCategoryController, action Index area Admin
		public static MapperConfiguration CategoryNewsIndexConf = new(mapper =>
		{
			mapper.CreateMap<AppNewsCategory, ListItemCategoryNewsVM>()
				.ForMember(vm => vm.TotalNews, opt => opt.MapFrom(entity => entity.NewsNavigation.Count));
		});

		// Cấu hình mapping cho NewsController, action Index area Admin
		public static MapperConfiguration NewsIndexConf = new(mapper =>
		{
			mapper.CreateMap<AppNews, ListItemNewsVM>()
			.ForMember(uItem => uItem.CategoryName, opts => opts.MapFrom(uEntity => uEntity.NewsCategory.Title));

			mapper.CreateMap<ListItemNewsVM, AppNews>();
			mapper.CreateMap<AppNews, ListItemNewsVM>().ReverseMap();
		});

		// Cấu hình mapping cho AppRTypeController, action Index area Admin
		public static MapperConfiguration RTypeIndexConf = new(mapper =>
		{
			mapper.CreateMap<AppRoomType, RTypeListItemVM>()
				.ForMember(
					uItem => uItem.RoomName,
					opt => opt.MapFrom(
						uEntity => uEntity.Rooms
							.Select(r => r.RoomName)
							.ToList()
					)
				);
		});

		// Cấu hình mapping cho AppRoomController, action Index area Admin
		public static MapperConfiguration RoomsIndexConf = new(mapper =>
		{
			mapper.CreateMap<AppRoom, RoomListItemVM>()
			.ForMember(
				uItem => uItem.ImagePath,
				opts => opts.MapFrom(
					uEntity => uEntity.ImgRooms
						.FirstOrDefault() == null ? "" : uEntity.ImgRooms.First().ImgSrc
				)
			)
			.ForMember(
				uItem => uItem.RoomTypeName,
				opts => opts.MapFrom(
					uEntity => uEntity.RoomType == null ? "" : uEntity.RoomType.RoomTypeName
				)
			)
			.ForMember(
				uItem => uItem.BranchName,
				opts => opts.MapFrom(
					uEntity => uEntity.Branch == null ? "" : uEntity.Branch.Name
				)
			)
			.ForMember(
				uItem => uItem.HotelName,
				opts => opts.MapFrom(
					uEntity => uEntity.Branch == null ? "" : uEntity.Branch.Hotel.Name
				)
			)
			.ForMember(
				uItem => uItem.EquipmentName,
				opts => opts.MapFrom(
					uEntity => uEntity.RoomEquipments
						.Select(re => re.Equipment.Name)
						.ToList()
				)
			);
		});

		// Cấu hình mapping cho NewsController, action Index area Client
		public static MapperConfiguration NewsIndexClientConf = new(mapper =>
		{
			mapper.CreateMap<AppNews, NewsVM>()
			.ForMember(uItem => uItem.CreatedByName, opst => opst.MapFrom(uEntity => uEntity.Users.FullName))
			.ForMember(uItem => uItem.CategoryName, opts => opts.MapFrom(uEntity => uEntity.NewsCategory.Title));

			mapper.CreateMap<NewsVM, AppNews>();
			mapper.CreateMap<AppNews, NewsVM>().ReverseMap();
		});

		// Cấu hình mapping cho RoomController, action Index area Admin
		public static MapperConfiguration RoomsIndexClientConf = new(mapper =>
		{
			mapper.CreateMap<AppRoom, RoomVM>()
			.ForMember(
				uItem => uItem.ImagePath,
				opts => opts.MapFrom(
					uEntity => uEntity.ImgRooms
						.FirstOrDefault() == null ? "" : uEntity.ImgRooms.First().ImgSrc
				)
			)
			.ForMember(
				uItem => uItem.RoomTypeName,
				opts => opts.MapFrom(
					uEntity => uEntity.RoomType == null ? "" : uEntity.RoomType.RoomTypeName
				)
			)
			.ForMember(
				uItem => uItem.BranchDesc,
				opts => opts.MapFrom(
					uEntity => uEntity.Branch == null ? "" : uEntity.Branch.Description
				)
			)
			.ForMember(
				uItem => uItem.HotelName,
				opts => opts.MapFrom(
					uEntity => uEntity.Branch == null ? "" : uEntity.Branch.Hotel.Name
				)
			)
			.ForMember(
				uItem => uItem.EquipmentName,
				opts => opts.MapFrom(
					uEntity => uEntity.RoomEquipments
						.Select(re => re.Equipment.Name)
						.ToList()
				)
			);
		});

		public static MapperConfiguration CartConf = new(mapper =>
		{
			mapper.CreateMap<AppRoom, CartItemVM>()
			.ForMember(uItem => uItem.RTypeName, opts => opts.MapFrom(uEntity => uEntity.RoomType == null ? "" : uEntity.RoomType.RoomTypeName))
			.ForMember(uItem => uItem.ImagePath, opts =>
				opts.MapFrom(uEntity => uEntity.ImgRooms.FirstOrDefault() == null ? "" : uEntity.ImgRooms.First().ImgSrc)
			)
			.ForMember(uItem => uItem.HotelName, opts => opts.MapFrom(uEntity => uEntity.Branch.Hotel == null ? "" : uEntity.Branch.Hotel.Name))
			.ForMember(uItem => uItem.BranchDesc, opts => opts.MapFrom(uEntity => uEntity.Branch == null ? "" : uEntity.Branch.Description)).ReverseMap();
		});

		public static MapperConfiguration OrderConf = new(mapper =>
		{
			mapper.CreateMap<AppOrderDetail, ListItemOrderDetailVM>();
			mapper.CreateMap<AppOrder, ListItemOrderVM>()
				.ForMember(x => x.AppOrderDetails, opt => opt.MapFrom(x => x.OrderDetails));
		});

		public static MapperConfiguration OrderDetailConf = new(mapper =>
		{
			mapper.CreateMap<AppOrderDetail, ListItemOrderDetailVM>().ReverseMap();
		});
	}
}