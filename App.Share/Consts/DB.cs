namespace App.Share.Consts
{
	public static class DB
	{
		#region User
		public static class AppRole
		{
			public const string TABLE_NAME					= "AppRole";
			public const short NAME_LENGTH					= 50;
			public const short DESC_LENGTH					= 100;
		}

		public static class AppRolePermission
		{
			public const string TABLE_NAME					= "AppRolePermission";
		}
		
		public static class AppUser
		{
			public const string TABLE_NAME					= "AppUser";
			public const short USERNAME_LENGTH				= 200;
			public const short PWD_LENGTH					= 200;
			public const short FULLNAME_LENGTH				= 100;
			public const short PHONE_LENGTH					= 15;
			public const short EMAIL_LENGTH					= 200;
			public const short ADDRESS_LENGTH				= 150;
			public const short AVATAR_LENGTH				= 200;
			public const short CITIZENID_LENGTH				= 12;
			public const short PASSPORT_LENGTH				= 12;
			public const short PERMANENT_LENGTH				= 15;
		}

		public static class MstPermission
		{
			public const string TABLE_NAME					= "MstPermission";
			public const short CODE_LENGTH					= 50;
			public const short TABLE_LENGTH					= 50;
			public const short GROUPNAME_LENGHT				= 100;
			public const short DESC_LENGHT					= 255;
		}
		
		#region Staff
		public static class AppPayroll
		{
			public const string TABLE_NAME					= "AppPayroll";
			public const short SALARY_LENGTH				= 10;
		}

		public static class AppWorkSchedule
		{
			public const string TABLE_NAME					= "AppWorkSchedule";
			public const string DEFAULT_DATE				= "GETDATE()";
		}

		public static class AppWorkShift
		{
			public const string TABLE_NAME					= "AppWorkShift";
			public const short NAME_LENGTH					= 200;
		}
		#endregion
		
		#endregion

		#region News
		public static class AppCategoryNews
		{
			public const string TABLE_NAME					= "AppCategoryNews";
			public const short MAX_LENGTH					= 500;
			public const short TITLE_LENGTH					= 255;
			public const short SLUG_LENGTH					= 100;
			public const short COVER_IMG_LENGTH				= 255;
			public const string DEFAULT_DATE				= "GETDATE()";
		}
		public static class AppNews
		{
			public const string TABLE_NAME					= "AppNews";
			public const short MAX_LENGTH					= 500;
			public const short TITLE_LENGTH					= 255;
			public const short SLUG_LENGTH					= 100;
			public const short COVER_IMG_LENGTH				= 255;
			public const short COVER_IMG_THUMB_LENGTH		= 255;
			public const short STAMP_PATH_LENGTH			= 255;
			public const string DEFAULT_DATE				= "GETDATE()";
			public const bool PUBLIC_NEWS					= true;
			public const string DEFAULT_VALUE				= null;
			public const short COUNT						= 0;
		}
		#endregion

		#region System (Hotel)
		public static class AppHotel
		{
			public const string TABLE_NAME					= "AppHotel";
			public const short NAME_LENGTH					= 200;
			public const short SLUG_LENGTH					= 100;
			public const short DESC_LENGTH					= 255;
			public const short PHONE_LENGTH					= 15;
			public const short EMAIL_LENGTH					= 200;
			public const short IMG_BANNER_LENGTH			= 255;
		}

		public static class AppBranchHotel
		{
			public const string TABLE_NAME					= "AppBranchHotel";
			public const short NAME_LENGTH					= 200;
			public const short SLUG_LENGTH					= 100;
			public const short DESC_LENGTH					= 255;
			public const short IDMAP_LENGTH					= 255;
			public const short ADDRESS_LENGTH				= 150;
			public const short IMG_LENGTH					= 255;
		}
		#endregion

		#region Room
		public static class AppRoom
		{
			public const string TABLE_NAME					= "AppRoom";
			public const short NAME_LENGTH					= 5;
			public const short ROOM_NUMBER_LENGTH			= 6;
			public const short SLUG_LENGTH					= 100;
			public const short STATUS_LENGTH				= 100;
			public const short PRICE_LENGTH					= 10;
			public const short DISCOUNT_PRICE_LENGTH		= 10;
		}

		public static class RoomStatus
		{

			public const string STATUS_PENDING_NAME			= "Phòng đang được sửa chữa";
			public const string STATUS_PROCESSING_NAME		= "Phòng đang được dọn dẹp";
			public const string STATUS_BOOKING_NAME			= "Phòng đang được đặt";
			public const string STATUS_CHECKIN_NAME			= "Khách đã nhận phòng";
			public const string STATUS_CHECKOUT_NAME		= "Đã trả phòng - phòng trống";
			public const string STATUS_CANCELED_NAME		= "Đã hủy đặt phòng";
		}

		public static class AppRoomType
		{
			public const string TABLE_NAME					= "AppRoomType";
			public const short NAME_LENGTH					= 100;
			public const short MAXPEOPLE_LENGTH				= 2;
			public const short DESC_LENGTH					= 255;
			public const bool DEFAULT_VALUE					= true;
		}

		public static class AppImgRoom
		{
			public const string TABLE_NAME					= "AppImgRoom";
			public const short SRC_LENGTH					= 255;
		}

		public static class AppEquipment
		{
			public const string TABLE_NAME					= "AppEquipment";
			public const short NAME_LENGTH					= 200;
			public const short DESC_LENGTH					= 255;
		}

		public static class AppTypeEquipment{
			public const string TABLE_NAME					= "AppTypeEquipment";
			public const short NAME_LENGTH					= 200;
		}
		#endregion

		#region WebService
		public static class AppOrder
		{
			public const string TABLE_NAME					= "AppOrder";
			public const short TOTAL_LENGTH					= 10;
			public const short DEPOSIT_LENGTH				= 100;
		}

		public static class AppOrderDetail
		{
			public const string TABLE_NAME					= "AppOrderDetail";
			public const short ROOM_NAME_LENGTH				= 5;
			public const short ROOM_NUMBER_LENGTH			= 6;
			public const short PRICE_LENGTH					= 10;
			public const short FULLNAME_USER_LENGTH			= 200;
			public const short QUANTITY_LENGTH				= 2;
		}

		public static class AppComment
		{
			public const string TABLE_NAME					= "AppComment";
			public const short DESC_LENGTH					= 255;
		}

		public static class AppCommentDetail
		{
			public const string TABLE_NAME					= "AppCommentDetail";
			public const short CMT_DESC_LENGTH				= 255;
			public const short USER_NAME_LENGTH				= 200;
			public const short ROOM_NAME_LENGTH				= 5;
			public const short ROOM_NUMBER_LENGTH			= 6;
		}
		#endregion
	}
}