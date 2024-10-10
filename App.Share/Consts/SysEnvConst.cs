namespace App.Share.Consts
{
	public static class SysEnvConst
	{
		public const string LOGO_HEADER = "HeaderLogoPath";
		public const string LOGO_FOOTER = "FooterLogoPath";
		public const string BRAND_NAME = "BrandName";
		public const string BRAND_ADDRESS = "BrandAddress";
		public const string BRAND_PHONE = "BrandPhone";
		public const string FACEBOOK = "Facebook";
		public const string ZALO = "Zalo";
		public const string MESSENGER_EMBEDDED_CODE = "MessengerEmbeddedCode";
		public const string ZALO_EMBEDDED_CODE = "ZaloEmbeddedCode";
		public const string EMBEDDED_MAP = "EmbeddedMap";
		public const string ADMIN_RECIVER_MAIL = "AdminReciverMail";
		public const string KIOT_VIET_CLIENT_ID = "KiotVietClientId";
		public const string KIOT_VIET_CLIENT_SECRET_KEY = "KiotVietClientSecretKey";
		public const string YOUTUBE = "Youtube";
		public const string PRIMARY_MAIL = "PrimaryMail";
		public const string SECONDARY_MAIL = "SecondaryMail";
		public const string VIDEO_YOUTUBE = "VideoYoutube";

		public const string SEO_TITLE = "SEOTitle";
		public const string SEO_DESCRIPTION = "SEODescription";
		public const string SEO_KEYWORD = "SEOKeyword";
		public const string SEO_IMAGEPATH = "SEOImagePath";

		public const string DEFAULT_IMAGE = "DefaultImage";
		public const string COMPANY_INTRODUCE = "CompanyIntroduce";
		// Bộ công thương
		public const string MINISTRY_OF_INDUSTRY = "MinistryOfIndustry";

		public const string COMPANY_INTRODUCE_TITLE = "CompanyIntroduceTitle";
		public const string COMPANY_INTRODUCE_CONTENT = "CompanyIntroduceContent";
		public const string COMPANY_INTRODUCE_IMAGE_1 = "CompanyIntroduceImage1";
		public const string COMPANY_INTRODUCE_IMAGE_2 = "CompanyIntroduceImage2";
		public const string COMPANY_INTRODUCE_IMAGE_3 = "CompanyIntroduceImage3";
		public const string COMPANY_INTRODUCE_SELCTE = "CompanyIntroduceSelect";

		public const string COMPANY_RECUUIT = "CompanyRecruit";
		public const string COMPANY_RECUUIT_LINK = "CompanyRecruitLink";

		public const string BRAND_FULLNAME = "BrandFullName";
		public const string ICON_IMAGEPATH = "IconImagePath";
		public const string TAX_CODE = "TaxCode";

		public const string EMAILFORORDERINFORMATION = "EmailForOrderInformation";

		public const string COMPANY_REPRESENTATIVE = "CompanyRepresentative";

		public const string SEARCH_SUGGESTIONS = "SearchSuggestions";
		public const string LOGO_OTHER = "LogoOtherPositionPath";

		public static List<string> GetFields()
		{
			List<string> listFields = new List<string>() {
				LOGO_HEADER,
				LOGO_FOOTER,
				BRAND_NAME,
				BRAND_ADDRESS,
				BRAND_PHONE,
				FACEBOOK,
				ZALO,
				MESSENGER_EMBEDDED_CODE,
				ZALO_EMBEDDED_CODE,
				EMBEDDED_MAP,
				ADMIN_RECIVER_MAIL,
				KIOT_VIET_CLIENT_ID,
				KIOT_VIET_CLIENT_SECRET_KEY,
				YOUTUBE,
				PRIMARY_MAIL,
				SECONDARY_MAIL,
				VIDEO_YOUTUBE,
				SEO_TITLE,
				SEO_DESCRIPTION,
				SEO_KEYWORD,
				SEO_IMAGEPATH,
				DEFAULT_IMAGE,
				COMPANY_INTRODUCE,
				MINISTRY_OF_INDUSTRY,
				COMPANY_INTRODUCE_TITLE,
				COMPANY_INTRODUCE_CONTENT,
				COMPANY_INTRODUCE_IMAGE_1,
				COMPANY_INTRODUCE_IMAGE_2,
				COMPANY_INTRODUCE_IMAGE_3,
				COMPANY_INTRODUCE_SELCTE,
				COMPANY_RECUUIT,
				COMPANY_RECUUIT_LINK,
				BRAND_FULLNAME,
				ICON_IMAGEPATH,
				TAX_CODE,
				EMAILFORORDERINFORMATION,
				COMPANY_REPRESENTATIVE,
				SEARCH_SUGGESTIONS,
				LOGO_OTHER,
			};
			return listFields;
		}
	}
}