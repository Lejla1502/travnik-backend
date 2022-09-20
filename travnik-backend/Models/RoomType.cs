namespace travnik_backend.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public int Capacity { get; set; }
        //public double Price { get; set; }
        public RoomAvail Status { get; set; }
        public List<Models.Accomodation.Accomodation> Accomodations { get; set; }
        public List<Bed> Beds { get; set; }

    }

    public enum RoomAvail
    {
        Booked, Available
    }
}
