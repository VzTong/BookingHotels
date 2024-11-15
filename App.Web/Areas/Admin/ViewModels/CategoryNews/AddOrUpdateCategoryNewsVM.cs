using App.Share.Attributes;
using App.Share.Consts;
using App.Web.WebConfig.Consts;

namespace App.Web.Areas.Admin.ViewModels.CategoryNews
{
	public class AddOrUpdateCategoryNewsVM
	{
		public int Id { get; set; }

		[AppRequired]
		[AppStringLength(VM.CategoryNewsVM.MIN_LENGTH, DB.AppNewsCategory.MAX_LENGTH)]
		public string Title { get; set; }
		[AppMaxLength(DB.AppNewsCategory.MAX_LENGTH)]
		public string? Content { get; set; }
		public string? CoverImgPath { get; set; }
		public IFormFile? ImgPath { get; set; }
		public DateTime? UpdatedDate { get; set; }
	}
}