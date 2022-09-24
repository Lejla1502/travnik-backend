

using System.Text.Json.Serialization;

namespace travnik_backend.Models.AccomodationType
{
    public class AccomodationType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        /*public string */
        
       [JsonIgnore]
        public List<Accomodation.Accomodation>? Accomodations { get; set; }
        public List<Listing> Listing { get; set; }
    }
}
