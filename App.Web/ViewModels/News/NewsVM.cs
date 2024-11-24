namespace App.Web.ViewModels.News
{
	public class NewsVM
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public long Views { get; set; }
		public float Votes { get; set; }
        public string? Summary { get; set; }
        public string? Content { get; set; }
        public string? CoverImgPath { get; set; }
		public string? CoverImgThumbnailPath { get; set; }
		public string? StampPath { get; set; }
		public string CreatedByName { get; set; }
		public DateTime? CreatedDate { get; set; }
		public string? CategoryName { get; set; }
	}
}