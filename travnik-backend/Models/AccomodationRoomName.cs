﻿namespace travnik_backend.Models
{
    public class AccomodationRoomName
    {
        public int AccomodationId { get; set; }
        public Models.Accomodation.Accomodation Accomodation { get; set; }
        public int RoomNameId { get; set; }
        public RoomName RoomName { get; set; }
        public int NumOfRoomsOfThisType { get; set; }
    }
}