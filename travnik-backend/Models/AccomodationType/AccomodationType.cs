

using System.Text.Json.Serialization;

namespace travnik_backend.Models.AccomodationType
{
    public class AccomodationType
    {
        public int Id { get; set; }
        public string Name { get; set; }
       [JsonIgnore]
        public List<Accomodation.Accomodation>? Accomodations { get; set; }
    }
}
