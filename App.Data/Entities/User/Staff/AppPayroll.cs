using App.Data.Entities.Base;

namespace App.Data.Entities.User.Staff
{
	public class AppPayroll : AppEntityBase
	{
		public double Salary { get; set; }
		public int StaffId { get; set; }

		public AppUser Staff { get; set; }
	}
}