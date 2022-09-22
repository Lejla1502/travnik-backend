﻿namespace travnik_backend.Models
{
    //this is property of hotel, apartment and so on (like room or apartment) - similar to room
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RoomNumber { get; set; }
        /*BreakfastInluded{get;set;}*/
        public int AccomodationId { get; set; }
        public Models.Accomodation.Accomodation Accomodation { get; set; }
        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
    }
}