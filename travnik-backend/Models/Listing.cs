namespace travnik_backend.Models
{
    public class Listing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Models.AccomodationType.AccomodationType> AccomodationTypes { get; set; }
        public List<ListingType> ListingTypes { get; set; }
    }
}
