using App.Data.Entities.Base;

namespace App.Data.Entities.Room
{
    public class AppEquipment : AppEntityBase
    {
        public AppEquipment()
        {
            RoomEquipments = new HashSet<AppRoomEquipment>();
        }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int? TypeEquipmentId { get; set; }

        public AppEquipmentType? TypeEquipment { get; set; }
        public ICollection<AppRoomEquipment> RoomEquipments { get; set; }
    }
}