using App.Data.Entities.Base;
using App.Data.Entities.Hotel;
using App.Data.Entities.Room;

namespace App.Data.Entities.service
{
    public class AppOrderDetail : AppEntityBase
    {
        public DateTime InvoiceDate { get; set; }
        public string RoomName { get; set; }
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double Price { get; set; }
        public double? DiscountPrice { get; set; }
        public string FullNameUser { get; set; }
        public int QuantityRoom { get; set; }
        public int RoomId { get; set; }
        public int OrderId { get; set; }

        public AppRoom Room { get; set; }
        public AppOrder Order { get; set; }
    }
}