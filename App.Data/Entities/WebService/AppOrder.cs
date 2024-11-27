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
		public string CusName { get; set; }
		public string CusPhone { get; set; }
		public string CusEmail { get; set; }
		public string? CusNote { get; set; }
		public decimal? TotalPrice { get; set; }
        public int QuantityRoom { get; set; }
		public string Status { get; set; }
		public int? CustomerId { get; set; }

		virtual public AppUser Customer { get; set; }
        virtual public ICollection<AppOrderDetail> OrderDetails { get; set; }
    }
}