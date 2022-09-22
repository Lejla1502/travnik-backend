namespace travnik_backend.Models
{
    public class ListingType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       public List<Listing> Listings { get; set; } 
    }
}
