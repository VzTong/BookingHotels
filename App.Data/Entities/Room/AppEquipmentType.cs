using App.Data.Entities.Base;

namespace App.Data.Entities.Room
{
    public class AppEquipmentType : AppEntityBase
    {
        public AppEquipmentType()
        {
            Equipments = new HashSet<AppEquipment>();
        }
        public string Name { get; set; }

        public ICollection<AppEquipment> Equipments { get; set; }
    }
}