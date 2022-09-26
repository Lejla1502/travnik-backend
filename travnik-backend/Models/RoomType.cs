namespace travnik_backend.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public int Capacity { get; set; }
        //public double Price { get; set; }
        //public RoomAvail Status { get; set; }
        //public List<AccomodationRoomType> AccomodationRoomTypes { get; set; }
        public List<Bed> Beds { get; set; }
        public List<RoomName> Rooms { get; set; }
    }

    public enum RoomAvail
    {
        Booked, Available
    }
}
