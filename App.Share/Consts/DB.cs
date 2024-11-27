namespace App.Share.Consts
{
	public static class DB
	{
		#region User
		public static class AppRole
		{
			public const string TABLE_NAME					= "AppRole";
			public const short NAME_LENGTH					= 100;
			public const short DESC_LENGTH					= 500;
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
			public const short PHONE_LENGTH					= 20;
			public const short EMAIL_LENGTH					= 200;
			public const short ADDRESS_LENGTH				= 150;
			public const short AVATAR_LENGTH				= 500;
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
		public static class AppNewsCategory
        {
			public const string TABLE_NAME					= "AppNewsCategory";
			public const short MAX_LENGTH					= 500;
			public const short TITLE_LENGTH					= 255;
			public const short SLUG_LENGTH					= 100;
			public const short COVER_IMG_LENGTH				= 500;
			public const string DEFAULT_DATE				= "GETDATE()";
		}
		public static class AppNews
		{
			public const string TABLE_NAME					= "AppNews";
			public const short MAX_LENGTH					= 500;
			public const short TITLE_LENGTH					= 255;
			public const short SLUG_LENGTH					= 100;
			public const short COVER_IMG_LENGTH				= 500;
			public const short COVER_IMG_THUMB_LENGTH		= 500;
			public const short STAMP_PATH_LENGTH			= 500;
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
			public const short IMG_BANNER_LENGTH			= 500;
			public const bool ISACTIVE						= true;
		}

		public static class AppBranchHotel
		{
			public const string TABLE_NAME					= "AppBranchHotel";
			public const short NAME_LENGTH					= 200;
			public const short SLUG_LENGTH					= 100;
			public const short DESC_LENGTH					= 255;
			public const short IDMAP_LENGTH					= 255;
			public const short ADDRESS_LENGTH				= 150;
			public const short IMG_LENGTH					= 500;
		}
		#endregion

		#region Room
		public static class AppRoom
		{
			public const string TABLE_NAME					= "AppRoom";
			public const short NAME_LENGTH					= 50;
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
			public const string STATUS_CANCELED_NAME		= "Đã hủy đặt phòng - phòng trống";
		}

		public static class AppRoomType
		{
			public const string TABLE_NAME					= "AppRoomType";
			public const short NAME_LENGTH					= 100;
			public const short MAXPEOPLE_LENGTH				= 2;
			public const short DESC_LENGTH					= 255;
			public const bool DEFAULT_VALUE					= true;
		}

		public static class AppRoomTypeName
		{
			public const string SINGLE_ROOM					= "SINGLE";
			public const string DOUBLE_ROOM					= "DOUBLE";
			public const string FAMILY_ROOM					= "FAMILY";
			public const string LUXURY_ROOM					= "LUXURY";
			public const string VIP_ROOM					= "VIP";

			public const int SINGLE_ROOM_ID					= 1;
			public const int DOUBLE_ROOM_ID					= 2;
			public const int FAMILY_ROOM_ID					= 3;
			public const int LUXURY_ROOM_ID					= 4;
			public const int VIP_ROOM_ID					= 5;
		}

		public static class AppImgRoom
		{
			public const string TABLE_NAME					= "AppImgRoom";
			public const short SRC_LENGTH					= 500;
		}

		public static class AppEquipment
		{
			public const string TABLE_NAME					= "AppEquipment";
			public const short NAME_LENGTH					= 200;
			public const short DESC_LENGTH					= 255;
		}

		public static class AppRoomEquipment
		{
			public const string TABLE_NAME					= "AppRoomEquipment";
		}

		public static class AppEquipmentType
        {
			public const string TABLE_NAME					= "AppEquipmentType";
			public const short NAME_LENGTH					= 200;
		}
		#endregion

		#region WebService
		public static class AppOrder
		{
			public const string TABLE_NAME					= "AppOrder";
			public const short CUS_NAME_LENGTH				= 100;
			public const short CUS_PHONE_LENGTH				= 20;
			public const short CUS_EMAIL_LENGTH				= 200;
			public const short DELIVERY_ADDRESS_LENGTH		= 150;
			public const short CUS_NOTE_LENGTH				= 500;
		}

        public static class OrderStatus
        {
            public const string STATUS_PROCESSING_NAME = "Hóa đơn đang được chờ thanh toán";
            public const string STATUS_DONE_NAME = "Hóa đơn đã thanh toán";
        }

        public static class AppOrderDetail
		{
			public const string TABLE_NAME					= "AppOrderDetail";
			public const short PRICE_LENGTH					= 10;
			public const short FULLNAME_USER_LENGTH			= 200;
		}

		public static class AppComment
		{
			public const string TABLE_NAME					= "AppComment";
			public const short DESC_LENGTH					= 255;
		}
		#endregion
	}
}