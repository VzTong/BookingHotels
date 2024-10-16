using App.Data.Entities.User;
using App.Web.Areas.Admin.ViewModels.Account;
using App.Web.ViewModels.Account;
using AutoMapper;

namespace App.Web.WebConfig
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			// Map dữ liệu từ kiểu UserAddOrEditVM sang AppUser
			//CreateMap<UserAddOrEditVM, AppUser>();

			// Map dữ liệu từ kiểu AppUser sang UserAddOrEditVM
			//CreateMap<AppUser, UserAddOrEditVM>();
			CreateMap<AppUser, UpdateUserViewModel>().ReverseMap();
			CreateMap<AppUser, UserDataForApp>().ReverseMap();
			CreateMap<AppUser, AcceptUpdateViewModel>().ReverseMap();
			CreateMap<AppUser, UserRegisterVM>().ReverseMap();
			CreateMap<AppUser, UserProfileClientVM>().ReverseMap();
		}

		//public static MapperConfiguration RoleIndexConf = new(mapper =>
		//{
		//	// Map dữ liệu từ kiểu AppRole sang RoleListItemVM
		//	mapper.CreateMap<AppRole, RoleListItemVM>();
		//});

		// Cấu hình mapping cho UserController, action Index
		//public static MapperConfiguration UserIndexConf = new(mapper =>
		//{
		//	// Map dữ liệu từ AppUser sang UserListItemVM, map thuộc tính RoleName
		//	mapper.CreateMap<AppUser, UserListItemVM>()
		//		.ForMember(uItem => uItem.RoleName, opts => opts.MapFrom(uEntity => uEntity.AppRole.Name));
		//});

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
		//public static MapperConfiguration RoleDeleteConf = new(mapper =>
		//{
		//	// Map dữ liệu thuộc tính con
		//	mapper.CreateMap<AppUser, RoleDeleteVM_User>();
		//	// Map dữ liệu thuộc tính cha
		//	mapper.CreateMap<AppRole, RoleDeleteVM>();
		//});

		//public static MapperConfiguration CategoryNewsConf = new(mapper =>
		//{
		//	mapper.CreateMap<AppCategoryNews, ListItemCategoryNewsVM>()
		//		.ForMember(vm => vm.TotalNews, opt => opt.MapFrom(entity => entity.NewsNavigation.Count));
		//});

		//public static MapperConfiguration NewsConf = new(mapper =>
		//{
		//	mapper.CreateMap<AppNews, ListItemNewsVM>()
		//	.ForMember(vm => vm.CategoryName, opt =>
		//		opt.MapFrom(entity =>
		//			entity.CategoryNews == null ? "" : entity.CategoryNews.Title
		//		)
		//	);
		//	mapper.CreateMap<ListItemNewsVM, AppNews>();
		//	mapper.CreateMap<AppNews, ListNewsVM>().ReverseMap();
		//});

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

		//public static MapperConfiguration MstBrandConf = new(mapper =>
		//{
		//	mapper.CreateMap<MstProductBrand, ListItemProductBrandVM>()
		//		.ForMember(item => item.CountProduct, options => options.MapFrom(entity =>
		//			entity.Products.Where(p => p.IsActive == true && p.DeletedDate == null).Count()
		//		));

		//	mapper.CreateMap<MstProductBrand, MstProductBrandListItemVM>()
		//		.ForMember(item => item.Quality, options => options.MapFrom(entity =>
		//			entity.Products.Where(p => p.DeletedDate == null).Count()
		//		)).ReverseMap();
		//});
	}
}