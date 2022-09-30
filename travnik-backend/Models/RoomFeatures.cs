namespace travnik_backend.Models
{
    public class RoomFeatures
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public List<AccomodationRoomName> AccomodationRoomNames { get; set; }
    }
}
