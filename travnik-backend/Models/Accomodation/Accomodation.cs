﻿namespace travnik_backend.Models.Accomodation
{
    public class Accomodation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double PricePerNight { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public int AccomodationTypeId { get; set; }
        public Models.AccomodationType.AccomodationType AccomodationType { get; set; }

        public List<Features> Features { get; set; }
        public List<RoomType> RoomTypes { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
