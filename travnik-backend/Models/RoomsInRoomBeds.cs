namespace travnik_backend.Models
{
    public class RoomsInRoomBeds
    {
        public int RoomsInRoomId { get; set; }
        public RoomsInRoom RoomsInRoom { get; set; }
        public int BedId { get; set; }
        public Bed Bed { get; set; }
    }
}
