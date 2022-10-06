using System.ComponentModel.DataAnnotations.Schema;

namespace travnik_backend.Models
{
    public class AccomodationRoomName
    {
        public int Id { get; set; }
        [ForeignKey("AccomodationId")]
        public int AccomodationId { get; set; }
        public Models.Accomodation.Accomodation Accomodation { get; set; }
        [ForeignKey("RoomNameId")]
        public int RoomNameId { get; set; }
        public RoomName RoomName { get; set; }
        public int NumOfRoomsOfThisType { get; set; }
        public double PricePerNight { get; set; }
        //should below parameters be in a different table (RoomNameDetails

        //public bool HasBedroomOrLivingRoom { get; set; } //should this be in accomodation - no
        //public int NumOfBedrooms { get; set; }
        //public int NumOfLivingRooms { get; set; }
        //public int NumOfBathrooms { get; set; }
        
        public List<AccomodationRoomNameBed> AccomodationRoomNameBeds { get; set; }
        public List<RoomFeatures> RoomFeatures { get; set; }

    }
}
