using App.Data.Entities.Base;
using App.Data.Entities.User;

namespace App.Data.Entities.service
{
    public class AppCommentDetail : AppEntityBase
    {
        public string CmtDesc { get; set; }
        public string UserName { get; set; }
        public string RoomName { get; set; }
        public int RoomNumber { get; set; }
        public int CommentId { get; set; }

		public AppUser User { get; set; }
		public AppComment Comment { get; set; }
    }
}