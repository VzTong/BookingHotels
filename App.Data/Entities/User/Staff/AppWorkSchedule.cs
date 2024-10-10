using App.Data.Entities.Base;

namespace App.Data.Entities.User.Staff
{
	public class AppWorkSchedule : AppEntityBase
	{
        public AppWorkSchedule()
        {
            WorkShifts = new HashSet<AppWorkShift>();
        }
        public DateTime Day{ get; set; }
		public int StaffId { get; set; }

		public AppUser Staff { get; set; }
		public ICollection<AppWorkShift> WorkShifts { get; set; }
	}
}