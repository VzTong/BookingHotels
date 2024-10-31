using App.Data.Entities.User;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Data.DataSeeders
{
	public static class MstPermissionSeeder
	{
		public static void SeedData(this EntityTypeBuilder<MstPermission> builder)
		{
			var now = new DateTime(year: 2024, month: 10, day: 10);
			var groupName = "";

			#region Data liên quan đến bảng Role
			// Permission liên quan đến bảng AppRole
			groupName = "Quản lý phân quyền";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppRole.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppRole.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem danh sách quyền",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppRole.VIEW_DETAIL,
					Code = "VIEW_DETAIL",
					Table = DB.AppRole.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem chi tiết quyền",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppRole.CREATE,
					Code = "CREATE",
					Table = DB.AppRole.TABLE_NAME,
					GroupName = groupName,
					Desc = "Thêm quyền",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppRole.UPDATE,
					Code = "UPDATE",
					Table = DB.AppRole.TABLE_NAME,
					GroupName = groupName,
					Desc = "Sửa quyền",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppRole.DELETE,
					Code = "DELETE",
					Table = DB.AppRole.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa quyền",
					CreatedDate = now
				}
			);
			#endregion

			#region Data quản lý người dùng
			// Permission liên quan đến bảng AppUser
			groupName = "Quản lý người dùng";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppUser.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppUser.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem danh sách người dùng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppUser.VIEW_DETAIL,
					Code = "VIEW_DETAIL",
					Table = DB.AppUser.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem chi tiết người dùng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppUser.CREATE,
					Code = "CREATE",
					Table = DB.AppUser.TABLE_NAME,
					GroupName = groupName,
					Desc = "Thêm người dùng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppUser.UPDATE,
					Code = "UPDATE",
					Table = DB.AppUser.TABLE_NAME,
					GroupName = groupName,
					Desc = "Cập nhật người dùng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppUser.UPDATE_PWD,
					Code = "UPDATE_PWD",
					Table = DB.AppUser.TABLE_NAME,
					GroupName = groupName,
					Desc = "Đổi mật khẩu",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppUser.BLOCK,
					Code = "BLOCK",
					Table = DB.AppUser.TABLE_NAME,
					GroupName = groupName,
					Desc = "Khóa người dùng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppUser.UNBLOCK,
					Code = "UNBLOCK",
					Table = DB.AppUser.TABLE_NAME,
					GroupName = groupName,
					Desc = "Mở khóa người dùng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppUser.DELETE,
					Code = "DELETE",
					Table = DB.AppUser.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa người dùng",
					CreatedDate = now
				}
			);
			#endregion

			#region Data liên quan đến quản lý file
			// Permission liên quan đến quản lý file
			groupName = "Quản lý file";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.FileManager.MANAGE_ALL_USER_FILES,
					Code = "MANAGER",
					Table = "FileManager",
					GroupName = groupName,
					Desc = "Quản lý file hệ thống",
					CreatedDate = now
				}
			);
			#endregion

			#region Data quản lý tin tức
			// Permission liên quan đến bảng AppNews
			groupName = "Quản lý tin tức";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppNews.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppNews.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem danh sách bài viết",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppNews.CREATE,
					Code = "CREATE",
					Table = DB.AppNews.TABLE_NAME,
					GroupName = groupName,
					Desc = "Thêm bài viết",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppNews.UPDATE,
					Code = "UPDATE",
					Table = DB.AppNews.TABLE_NAME,
					GroupName = groupName,
					Desc = "Cập nhật bài viết",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppNews.DELETE,
					Code = "DELETE",
					Table = DB.AppNews.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa bài viết",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppNews.PUBLIC,
					Code = "PUBLIC",
					Table = DB.AppNews.TABLE_NAME,
					GroupName = groupName,
					Desc = "Công khai bài viết",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppNews.UNPUBLIC,
					Code = "UNPUBLIC",
					Table = DB.AppNews.TABLE_NAME,
					GroupName = groupName,
					Desc = "Gỡ bỏ bài viết",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppNews.SENDMAILREGISTER,
					Code = "SENDMAILREGISTER",
					Table = DB.AppNews.TABLE_NAME,
					GroupName = groupName,
					Desc = "Gữi email người đăng ký",
					CreatedDate = now
				}
				);
			#endregion

			#region Data quản lý thể loại tin tức
			// Permission liên quan đến bảng AppCategoryNews
			groupName = "Quản lý thể loại tin";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppCategoryNews.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppNewsCategory.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem danh sách thể loại tin",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppCategoryNews.CREATE,
					Code = "CREATE",
					Table = DB.AppNewsCategory.TABLE_NAME,
					GroupName = groupName,
					Desc = "Thêm thể loại bài viết",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppCategoryNews.UPDATE,
					Code = "UPDATE",
					Table = DB.AppNewsCategory.TABLE_NAME,
					GroupName = groupName,
					Desc = "Cập nhật thể loại bài viết",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppCategoryNews.DELETE,
					Code = "DELETE",
					Table = DB.AppNewsCategory.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa thể loại bài viết",
					CreatedDate = now
				}
				);
			#endregion

			#region Data quản lý chi nhánh khách sạn
			// Permission liên quan đến bảng AppBranchHotel
			groupName = "Quản lý chi nhánh khách sạn";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppBranchHotel.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppBranchHotel.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem danh sách chi nhánh khách sạn",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppBranchHotel.CREATE,
					Code = "CREATE",
					Table = DB.AppBranchHotel.TABLE_NAME,
					GroupName = groupName,
					Desc = "Thêm chi nhánh khách sạn",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppBranchHotel.UPDATE,
					Code = "UPDATE",
					Table = DB.AppBranchHotel.TABLE_NAME,
					GroupName = groupName,
					Desc = "Cập nhật chi nhánh",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppBranchHotel.DELETE,
					Code = "DELETE",
					Table = DB.AppBranchHotel.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa chi nhánh",
					CreatedDate = now
				}
				);
			#endregion

			#region Data quản lý khách sạn
			// Permission liên quan đến bảng AppHotel
			groupName = "Quản lý khách sạn";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppHotel.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppHotel.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem danh sách khách sạn",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppHotel.CREATE,
					Code = "CREATE",
					Table = DB.AppHotel.TABLE_NAME,
					GroupName = groupName,
					Desc = "Thêm khách sạn",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppHotel.UPDATE,
					Code = "UPDATE",
					Table = DB.AppHotel.TABLE_NAME,
					GroupName = groupName,
					Desc = "Cập nhật khách sạn",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppHotel.DELETE,
					Code = "DELETE",
					Table = DB.AppHotel.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa khách sạn",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppHotel.PUBLIC,
					Code = "PUBLIC",
					Table = DB.AppHotel.TABLE_NAME,
					GroupName = groupName,
					Desc = "Công khai khách sạn",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppHotel.UNPUBLIC,
					Code = "UNPUBLIC",
					Table = DB.AppHotel.TABLE_NAME,
					GroupName = groupName,
					Desc = "Gỡ khách sạn xuống",
					CreatedDate = now
				}
				);
			#endregion

			#region Data quản lý phòng khách sạn
			// Permission liên quan đến bảng AppRoom
			groupName = "Quản lý phòng khách sạn";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppRoom.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppRoom.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem danh sách phòng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppRoom.CREATE,
					Code = "CREATE",
					Table = DB.AppRoom.TABLE_NAME,
					GroupName = groupName,
					Desc = "Thêm phòng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppRoom.UPDATE,
					Code = "UPDATE",
					Table = DB.AppRoom.TABLE_NAME,
					GroupName = groupName,
					Desc = "Cập nhật phòng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppRoom.DELETE,
					Code = "DELETE",
					Table = DB.AppRoom.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa phòng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppRoom.PUBLIC,
					Code = "PUBLIC",
					Table = DB.AppRoom.TABLE_NAME,
					GroupName = groupName,
					Desc = "Công khai phòng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppRoom.UNPUBLIC,
					Code = "UNPUBLIC",
					Table = DB.AppRoom.TABLE_NAME,
					GroupName = groupName,
					Desc = "Gỡ phòng xuống",
					CreatedDate = now
				});
			#endregion

			#region Data quản lý loại phòng của khách sạn
			// Permission liên quan đến bảng AppRoomType
			groupName = "Quản lý loại phòng";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppRoomType.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppRoomType.TABLE_NAME,
					GroupName = groupName,
					Desc = "Quản lý loại phòng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppRoomType.CREATE,
					Code = "CREATE",
					Table = DB.AppRoomType.TABLE_NAME,
					GroupName = groupName,
					Desc = "Thêm loại phòng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppRoomType.UPDATE,
					Code = "UPDATE",
					Table = DB.AppRoomType.TABLE_NAME,
					GroupName = groupName,
					Desc = "Cập nhật loại phòng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppRoomType.DELETE,
					Code = "DELETE",
					Table = DB.AppRoomType.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa loại phòng",
					CreatedDate = now
				});
			#endregion

			#region Data quản lý trang thiết bị
			// Permission liên quan đến bảng AppEquipment
			groupName = "Quản lý trang thiết bị";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppEquipment.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppEquipment.TABLE_NAME,
					GroupName = groupName,
					Desc = "Quản lý trang thiết bị",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppEquipment.CREATE,
					Code = "CREATE",
					Table = DB.AppEquipment.TABLE_NAME,
					GroupName = groupName,
					Desc = "Thêm mới trang thiết bị",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppEquipment.UPDATE,
					Code = "UPDATE",
					Table = DB.AppEquipment.TABLE_NAME,
					GroupName = groupName,
					Desc = "Cập nhật trang thiết bị",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppEquipment.DELETE,
					Code = "DELETE",
					Table = DB.AppEquipment.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa trang thiết bị",
					CreatedDate = now
				});
			#endregion
			
			#region Data quản lý loại trang thiết bị
			// Permission liên quan đến bảng AppTypeEquipment
			groupName = "Quản lý loại trang thiết bị";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppTypeEquipment.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppEquipmentType.TABLE_NAME,
					GroupName = groupName,
					Desc = "Quản lý loại trang thiết bị",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppTypeEquipment.CREATE,
					Code = "CREATE",
					Table = DB.AppEquipmentType.TABLE_NAME,
					GroupName = groupName,
					Desc = "Thêm mới loại trang thiết bị",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppTypeEquipment.UPDATE,
					Code = "UPDATE",
					Table = DB.AppEquipmentType.TABLE_NAME,
					GroupName = groupName,
					Desc = "Cập nhật loại trang thiết bị",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppTypeEquipment.DELETE,
					Code = "DELETE",
					Table = DB.AppEquipmentType.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa loại trang thiết bị",
					CreatedDate = now
				});
			#endregion

			#region Data quản lý đặt phòng của khách hàng
			// Permission liên quan đến bảng AppOrder
			groupName = "Quản lý đặt phòng";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppOrder.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppOrder.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem danh sách đặt phòng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppOrder.DETAILS,
					Code = "DETAILS",
					Table = DB.AppOrderDetail.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem chi tiết phòng được đặt",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppOrder.UPDATE,
					Code = "UPDATE",
					Table = DB.AppOrder.TABLE_NAME,
					GroupName = groupName,
					Desc = "Cập nhật trang thái đặt phòng",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppOrder.DELETE,
					Code = "DELETE",
					Table = DB.AppOrder.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa đặt phòng",
					CreatedDate = now
				});
			#endregion

			#region Data quản lý lương nhân viên
			// Permission liên quan đến bảng AppPayroll
			groupName = "Quản lý lương nhân viên";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppPayroll.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppPayroll.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem danh sách lương nhân viên",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppPayroll.VIEW_DETAIL,
					Code = "VIEW_LIST",
					Table = DB.AppPayroll.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem chi tiết lương nhân viên",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppPayroll.CREATE,
					Code = "CREATE",
					Table = DB.AppPayroll.TABLE_NAME,
					GroupName = groupName,
					Desc = "Tạo bảng lương mới cho nhân viên",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppPayroll.UPDATE,
					Code = "UPDATE",
					Table = DB.AppPayroll.TABLE_NAME,
					GroupName = groupName,
					Desc = "Cập nhật bảng lương cho nhân viên",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppPayroll.DELETE,
					Code = "DELETE",
					Table = DB.AppPayroll.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa bảng lương của nhân viên",
					CreatedDate = now
				});
			#endregion

			#region Data quản lý lịch làm nhân viên
			// Permission liên quan đến bảng AppWorkSchedule
			groupName = "Quản lý lịch làm nhân viên";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppWorkSchedule.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppWorkSchedule.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem danh sách lịch làm nhân viên",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppWorkSchedule.VIEW_DETAIL,
					Code = "VIEW_LIST",
					Table = DB.AppWorkSchedule.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem chi tiết lịch làm nhân viên",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppWorkSchedule.CREATE,
					Code = "CREATE",
					Table = DB.AppWorkSchedule.TABLE_NAME,
					GroupName = groupName,
					Desc = "Tạo lịch làm cho nhân viên",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppWorkSchedule.UPDATE,
					Code = "UPDATE",
					Table = DB.AppWorkSchedule.TABLE_NAME,
					GroupName = groupName,
					Desc = "Cập nhật lịch làm cho nhân viên",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppWorkSchedule.DELETE,
					Code = "DELETE",
					Table = DB.AppWorkSchedule.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa lịch làm của nhân viên",
					CreatedDate = now
				});
			#endregion

			#region Data quản lý ca làm nhân viên
			// Permission liên quan đến bảng AppWorkShift
			groupName = "Quản lý ca làm nhân viên";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppWorkShift.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppWorkShift.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem danh sách ca làm nhân viên",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppWorkShift.VIEW_DETAIL,
					Code = "VIEW_LIST",
					Table = DB.AppWorkShift.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem chi tiết ca làm nhân viên",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppWorkShift.CREATE,
					Code = "CREATE",
					Table = DB.AppWorkShift.TABLE_NAME,
					GroupName = groupName,
					Desc = "Tạo ca làm cho nhân viên",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppWorkShift.UPDATE,
					Code = "UPDATE",
					Table = DB.AppWorkShift.TABLE_NAME,
					GroupName = groupName,
					Desc = "Cập nhật ca làm cho nhân viên",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppWorkShift.DELETE,
					Code = "DELETE",
					Table = DB.AppWorkShift.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa ca làm của nhân viên",
					CreatedDate = now
				});
			#endregion

			#region Data quản lý bình luận người dùng
			// Permission liên quan đến bảng AppComment
			groupName = "Quản lý bình luận người dùng";
			builder.HasData(
				new MstPermission
				{
					Id = AuthConst.AppComment.VIEW_LIST,
					Code = "VIEW_LIST",
					Table = DB.AppComment.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xem danh sách các bình luận",
					CreatedDate = now
				},
				new MstPermission
				{
					Id = AuthConst.AppComment.AD_DELETE,
					Code = "DELETE",
					Table = DB.AppComment.TABLE_NAME,
					GroupName = groupName,
					Desc = "Xóa bình luận vi phạn",
					CreatedDate = now
				});
			#endregion
		}
	}
}