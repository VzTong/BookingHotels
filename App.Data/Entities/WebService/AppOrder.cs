using App.Data.Entities.Base;
using App.Data.Entities.User;

namespace App.Data.Entities.service
{
    public class AppOrder : AppEntityBase
    {
        public AppOrder()
        {
            OrderDetails = new HashSet<AppOrderDetail>();
        }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public DateTime TimeStay { get; set; }
        public double TotalPrice { get; set; }
        public double Deposit { get; set; }
        public string Status { get; set; }
		public int? EmployeeId { get; set; }

		public AppUser Employee { get; set; }
		virtual public AppUser Customer { get; set; }
        virtual public ICollection<AppOrderDetail> OrderDetails { get; set; }
    }
}