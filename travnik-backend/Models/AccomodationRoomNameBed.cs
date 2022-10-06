namespace travnik_backend.Models
{
    public class AccomodationRoomNameBed
    {
        public int AccomodationRoomNameId { get; set; }
        public AccomodationRoomName AccomodationRoomName { get; set; }
        public int BedId { get; set; }
        public Bed Bed { get; set; }
       // public int NumOfBedsOfThisType { get; set; }
        //public string Bedroom1 { get; set; }

        //public List<AccomodationRoomNameBed> AccomodationRoomNameBeds { get; set; }
    }
}
