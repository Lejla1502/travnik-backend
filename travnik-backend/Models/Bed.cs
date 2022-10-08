namespace travnik_backend.Models
{
    public class Bed
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        //public int Qty { get; set; }

        /*many to many between AccomodationRoomName and Beds*/
        public List<AccomodationRoomNameBed> AccomodationRoomNameBeds { get; set; }
        /*many to many between RoomsInRoom and Beds*/
        public List<RoomsInRoomBeds> RoomsInRoomBeds { get; set; }
    }
}
