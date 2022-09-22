namespace travnik_backend.Models
{
    public class ListingType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       List<Listing> listings { get; set; } 
    }
}
