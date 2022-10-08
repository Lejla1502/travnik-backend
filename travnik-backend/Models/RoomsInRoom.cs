using System.ComponentModel.DataAnnotations.Schema;

namespace travnik_backend.Models
{
    public class RoomsInRoom
    {
        public int Id { get; set; }
        //[ForeignKey("RoomNameDetailsId")]
        //public int RoomNameDetailsId { get; set; }
        //public RoomNameDetails RoomNameDetails { get; set; }
        //[ForeignKey("BedId")]
        //public int BedId { get; set; }
        //public Bed Bed { get; set; }
        public string NameOfTheRoom { get; set; }
        public int GuestsInThisRoom { get; set; }
        public bool PrivateBathroom { get; set; }

        public int RoomNameDetailsId { get; set; }
        public RoomNameDetails RoomNameDetails { get; set; }

        /*many to many between RoomsInRoom and Beds*/
        public List<RoomsInRoomBeds> RoomsInRoomBeds { get; set; }

    }
}
