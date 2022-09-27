using System.ComponentModel.DataAnnotations.Schema;

namespace travnik_backend.Models
{
    public class HotelRoomBed
    {
        public int AccomodationRoomNameId { get; set; }
        public AccomodationRoomName AccomodationRoomName { get; set; }
        public int BedId { get; set; }
        public Bed Bed { get; set; }
        public int NumOfBedsForThisRoom { get; set; }
    }
}
