namespace travnik_backend.Models
{
    public class RoomNameDetails
    {
        public int RoomNameDetailsId { get; set; }
        public int NumOfBedrooms { get; set; }
        public int NumOfLivingrooms { get; set; }
        public int NumOfBathrooms { get; set; }
        public int NumOfGuests { get; set; }
        public int RoomNameId { get; set; }
        public RoomName RoomName { get; set; }
    }
}
