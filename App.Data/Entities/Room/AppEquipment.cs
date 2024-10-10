using App.Data.Entities.Base;

namespace App.Data.Entities.Room
{
    public class AppEquipment : AppEntityBase
    {
        public AppEquipment()
        {
            Rooms = new HashSet<AppRoom>();
        }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int? TypeEquipmentId { get; set; }

        public AppTypeEquipment? TypeEquipment { get; set; }
        public ICollection<AppRoom> Rooms { get; set; }
    }
}