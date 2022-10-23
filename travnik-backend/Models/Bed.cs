using System.Text.Json.Serialization;

namespace travnik_backend.Models
{
    public class Bed
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        //public int Qty { get; set; }

        /*many to many between AccomodationRoomName and Beds*/
        [JsonIgnore]
        public List<AccomodationRoomNameBed> AccomodationRoomNameBeds { get; set; }
        /*many to many between RoomsInRoom and Beds*/
        [JsonIgnore]
        public List<RoomsInRoomBeds> RoomsInRoomBeds { get; set; }
    }
}
