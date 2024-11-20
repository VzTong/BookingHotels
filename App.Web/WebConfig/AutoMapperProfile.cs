using App.Data.Entities.Hotel;
using App.Data.Entities.News;
using App.Data.Entities.Room;
using App.Data.Entities.User;
using App.Web.Areas.Admin.ViewModels.Account;
using App.Web.Areas.Admin.ViewModels.BranchHotel;
using App.Web.Areas.Admin.ViewModels.CategoryNews;
using App.Web.Areas.Admin.ViewModels.Equipment;
using App.Web.Areas.Admin.ViewModels.EquipmentType;
using App.Web.Areas.Admin.ViewModels.Hotel;
using App.Web.Areas.Admin.ViewModels.News;
using App.Web.Areas.Admin.ViewModels.Role;
using App.Web.Areas.Admin.ViewModels.RoomType;
using App.Web.Areas.Admin.ViewModels.User;
using App.Web.ViewModels.Account;
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

			// Map dữ liệu của AppRoomType
			CreateMap<AppRoomType, AddOrUpdateRTypeVM>().ReverseMap();
		}

		// Cấu hình mapping cho RoleController, action Index
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

		// Cấu hình mapping cho UserController, action Index
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

		// Cấu hình mapping cho AppBranchHotelController, action Index
		public static MapperConfiguration BranchHotelIndexConf = new(mapper =>
		{
			mapper.CreateMap<AppBranchHotel, AppBranchHotelListItemVM>()
				.ForMember(uItem => uItem.HotelName, opts => opts.MapFrom(uEntity => uEntity.Hotel.Name));
		});

		// Cấu hình mapping cho AppHotelController, action Index
		public static MapperConfiguration HotelIndexConf = new(mapper =>
		{
			// Map dữ liệu từ AppHotel sang AppHotelListItemVM, map thuộc tính TypeEquipmentName
			mapper.CreateMap<AppHotel, AppHotelListItemVM>()
				.ForMember(
					uItem => uItem.BranchName,
					opts => opts.MapFrom(
						uEntity => uEntity.BranchHotels
							.Select(bh => bh.Name)
							.ToList()
					)
				);
		});

		// Cấu hình mapping cho AppEquipmentController, action Index
		public static MapperConfiguration EquipmentIndexConf = new(mapper =>
		{
			// Map dữ liệu từ AppEquipment sang EquipmentListItemVM, map thuộc tính TypeEquipmentName
			mapper.CreateMap<AppEquipment, EquipmentListItemVM>()
				.ForMember(uItem => uItem.TypeEquipmentName, opts => opts.MapFrom(uEntity => uEntity.TypeEquipment.Name));
		});

		// Cấu hình mapping cho AppETypeController, action Index
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

		// Cấu hình mapping cho AppNewsCategoryController, action Index
		public static MapperConfiguration CategoryNewsConf = new(mapper =>
		{
			mapper.CreateMap<AppNewsCategory, ListItemCategoryNewsVM>()
				.ForMember(vm => vm.TotalNews, opt => opt.MapFrom(entity => entity.NewsNavigation.Count));
		});

		// Cấu hình mapping cho AppNewsController, action Index
		public static MapperConfiguration NewsConf = new(mapper =>
		{
			mapper.CreateMap<AppNews, ListItemNewsVM>()
			.ForMember(uItem => uItem.CategoryName, opts => opts.MapFrom(uEntity => uEntity.NewsCategory.Title));

			mapper.CreateMap<ListItemNewsVM, AppNews>();
			mapper.CreateMap<AppNews, ListItemNewsVM>().ReverseMap();
		});

		// Cấu hình mapping cho AppRTypeController, action Index
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

		//public static MapperConfiguration ProductCategoryConf = new(mapper =>
		//{
		//	mapper.CreateMap<AppProductCategory, ListItemProductCategoryVM>().ReverseMap();
		//});

		//public static MapperConfiguration ProductsConf = new(mapper =>
		//{
		//	mapper.CreateMap<AppProduct, ListProductsVM>()
		//	.ForMember(uItem => uItem.CategoryName, opts =>
		//		opts.MapFrom(uEntity =>
		//			uEntity.ProductCategory == null ? "" :
		//				(uEntity.ProductCategory.ParentCategory == null ?
		//					uEntity.ProductCategory.Name :
		//					uEntity.ProductCategory.ParentCategory.Name + " > " + uEntity.ProductCategory.Name
		//			)
		//		)
		//	)
		//	.ForMember(uItem => uItem.ImagePath, opts =>
		//		opts.MapFrom(uEntity => uEntity.ProductImages.FirstOrDefault() == null ? "" : uEntity.ProductImages.First().ImagePath)
		//	)
		//	.ForMember(uItem => uItem.BrandName, opts => opts.MapFrom(uEntity => uEntity.ProductBrand == null ? "" : uEntity.ProductBrand.Name))
		//	.ForMember(uItem => uItem.QualityProduct, opts => opts.MapFrom(uEntity => uEntity.ProductCategory.AppProducts.Where(s => s.DeletedDate == null).Count())).ReverseMap();

		//	mapper.CreateMap<AppProduct, ListItemProductVM>()
		//	.ForMember(uItem => uItem.CategoryName, opts => opts.MapFrom(uEntity => uEntity.ProductCategory == null ? "" : uEntity.ProductCategory.Name))
		//	.ForMember(uItem => uItem.ImagePath, opts =>
		//		opts.MapFrom(uEntity => uEntity.ProductImages.FirstOrDefault() == null ? "" : uEntity.ProductImages.First().ImagePath)
		//	)
		//	.ForMember(uItem => uItem.BrandName, opts => opts.MapFrom(uEntity => uEntity.ProductBrand == null ? "" : uEntity.ProductBrand.Name))
		//	.ForMember(uItem => uItem.StampPathCategory, opts => opts.MapFrom(uEntity => uEntity.ProductCategory == null ? "" : uEntity.ProductCategory.StampPath));

		//});

		//public static MapperConfiguration OrderConf = new(mapper =>
		//{
		//	mapper.CreateMap<AppOrderDetail, ListItemOrderDetailVM>();
		//	mapper.CreateMap<AppOrder, ListItemOrderVM>()
		//		.ForMember(x => x.AppOrderDetails, opt => opt.MapFrom(x => x.AppOrderDetails));
		//});

		//public static MapperConfiguration OrderDetailConf = new(mapper =>
		//{
		//	mapper.CreateMap<AppOrderDetail, ListItemOrderDetailVM>().ReverseMap();
		//});

		//public static MapperConfiguration CartConf = new(mapper =>
		//{
		//	mapper.CreateMap<AppProduct, CartItemVM>()
		//	.ForMember(uItem => uItem.CategoryName, opts => opts.MapFrom(uEntity => uEntity.ProductCategory == null ? "" : uEntity.ProductCategory.Name))
		//	.ForMember(uItem => uItem.ImagePath, opts =>
		//		opts.MapFrom(uEntity => uEntity.ProductImages.FirstOrDefault() == null ? "" : uEntity.ProductImages.First().ImagePath)
		//	)
		//	.ForMember(uItem => uItem.BrandName, opts => opts.MapFrom(uEntity => uEntity.ProductBrand == null ? "" : uEntity.ProductBrand.Name)).ReverseMap();
		//});

		//public static MapperConfiguration CatalogueConf = new(mapper =>
		//{
		//	mapper.CreateMap<AppCatalogue, ListItemCatalogueVM>().ReverseMap();
		//});
	}
}