namespace App.Data.Entities.Room
{
    public class AppRoomEquipment
    {
        public int Id { get; set; }
        public int? RoomId { get; set; }
        public int? EquipmentId { get; set; }

        public AppRoom Room { get; set; }
        public AppEquipment Equipment { get; set; }
    }
}