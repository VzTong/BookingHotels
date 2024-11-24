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
        public decimal? TotalPrice { get; set; }
        public int QuantityRoom { get; set; }
		public int? CustomerId { get; set; }

		virtual public AppUser Customer { get; set; }
        virtual public ICollection<AppOrderDetail> OrderDetails { get; set; }
    }
}