using App.Share.Attributes;
using App.Share.Consts;

namespace App.Web.Areas.Admin.ViewModels.News
{
    public class AddOrUpdateNewsVM : ListItemBaseVM
    {
        [AppRequired]
        [AppMaxLength(DB.AppNews.MAX_LENGTH)]
        public string Title { get; set; }
        [AppMaxLength(DB.AppNews.MAX_LENGTH)]
        public string? Summary { get; set; }
        public string? Content { get; set; }
        [AppRequired]
        public int CategoryId { get; set; }
        [AppRequired]
        public string? CoverImgPath { get; set; }
        public string? CoverImgThumbnailPath { get; set; }
        public string? StampPath { get; set; }
        public bool SendAllEmail { get; set; }
    }
}