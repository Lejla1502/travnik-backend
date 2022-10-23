using System.Text.Json.Serialization;

namespace travnik_backend.Models
{
    //this is property of hotel, apartment and so on (like room or apartment) - similar to room
    public class RoomName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string RoomNumber { get; set; }
        ///*BreakfastInluded{get;set;}*/
        //public int AccomodationId { get; set; }
        //public Models.Accomodation.Accomodation Accomodation { get; set; }
        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
        [JsonIgnore]
        public List<AccomodationRoomName> AccomodationRoomNames { get; set; }
        //public List<BedRoomName> BedRoomNames { get; set; }
  
        //one to one
        public RoomNameDetails RoomNameDetails { get; set; }
    }
}
