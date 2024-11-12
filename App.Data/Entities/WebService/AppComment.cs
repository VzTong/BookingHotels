using App.Data.Entities.Base;
using App.Data.Entities.Room;

namespace App.Data.Entities.service
{
	public class AppComment : AppEntityBase
	{
		public AppComment()
		{
			CommentDetails = new HashSet<AppCommentDetail>();
		}
		public string Description { get; set; }
		public ICollection<AppCommentDetail> CommentDetails { get; set; }
	}
}