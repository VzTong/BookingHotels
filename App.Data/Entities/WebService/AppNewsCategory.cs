using App.Data.Entities.Base;

namespace App.Data.Entities.News
{
    public class AppNewsCategory : AppEntityBase
    {
        public AppNewsCategory()
        {
            NewsNavigation = new HashSet<AppNews>();
        }
        public string Title { get; set; }
        public string? Slug { get; set; }
        public string? Content { get; set; }
        public string? CoverImgPath { get; set; }
        public ICollection<AppNews> NewsNavigation { get; set; }
    }
}