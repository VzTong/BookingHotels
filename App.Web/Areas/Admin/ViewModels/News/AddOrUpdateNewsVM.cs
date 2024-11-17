using App.Share.Attributes;
using App.Share.Consts;

namespace App.Web.Areas.Admin.ViewModels.News
{
    public class AddOrUpdateNewsVM : ListItemBaseVM
    {
        [AppRequired]
        [AppMaxLength(DB.AppNews.MAX_LENGTH)]
        public string Title { get; set; }
        public string? Summary { get; set; }
        [AppMaxLength(DB.AppNews.MAX_LENGTH)]
        public string? Content { get; set; }
        [AppRequired]
        public int CategoryId { get; set; }
        public string? CoverImgPath { get; set; }
        [AppRequired]
        public IFormFile? ImgPath { get; set; }
        public string? CoverImgThumbnailPath { get; set; }
		[AppRequired]
		public IFormFile? ImgThumbnailPath { get; set; }
        public string? StampPath { get; set; }
		[AppRequired]
		public IFormFile? StampImgPath { get; set; }
        //public bool SendAllEmail { get; set; }
    }
}