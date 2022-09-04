namespace travnik_backend.Models
{
    public class Accomodation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double PricePerNight { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
