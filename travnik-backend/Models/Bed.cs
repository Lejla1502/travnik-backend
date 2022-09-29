namespace travnik_backend.Models
{
    public class Bed
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        //public int Qty { get; set; }
        
        public List<AccomodationRoomNameBed> AccomodationRoomNameBeds { get; set; }
    }
}
