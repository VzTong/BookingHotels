using App.Data.Entities.Base;

namespace App.Data.Entities.Room
{
    public class AppTypeEquipment : AppEntityBase
    {
        public AppTypeEquipment()
        {
            Equipments = new HashSet<AppEquipment>();
        }
        public string Name { get; set; }

        public ICollection<AppEquipment> Equipments { get; set; }
    }
}