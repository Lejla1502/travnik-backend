namespace travnik_backend.Models.Accomodation
{
    public class Accomodation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public double PricePerNight { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public int AccomodationTypeId { get; set; }
        public Models.AccomodationType.AccomodationType AccomodationType { get; set; }

       // public List<TopLevelFeatures> Features { get; set; }
        public List<AccomodationRoomName> AccomodationRoomNames { get; set; }
        //public List<RoomName> Rooms { get; set; }
    }
}
