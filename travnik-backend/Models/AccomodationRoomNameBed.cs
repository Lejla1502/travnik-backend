using System.ComponentModel.DataAnnotations.Schema;

namespace travnik_backend.Models
{
    public class AccomodationRoomNameBed
    {
        public int Id { get; set; }
        [ForeignKey("AccomodationRoomNameId")]
        public int AccomodationRoomNameId { get; set; }
        public AccomodationRoomName AccomodationRoomName { get; set; }
        [ForeignKey("BedId")]
        public int BedId { get; set; }
        public Bed Bed { get; set; }
        public int NumOfBedsOfThisType { get; set; }
        //public string Bedroom1 { get; set; }

        //public List<AccomodationRoomNameBed> AccomodationRoomNameBeds { get; set; }
    }
}
