using App.Data.Entities.Base;

namespace App.Data.Entities.User.Staff
{
	public class AppWorkShift : AppEntityBase
	{
        public string Name { get; set; }
		public TimeOnly StartTime { get; set; }
		public TimeOnly EndTime { get; set; }
		public int? WorkScheduleId { get; set; }

		public AppWorkSchedule WorkSchedule { get; set; }
	}
}