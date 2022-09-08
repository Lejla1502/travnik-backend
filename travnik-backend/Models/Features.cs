using System.Text.Json.Serialization;

namespace travnik_backend.Models
{
    public class Features
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Models.Accomodation.Accomodation>? Accomodations { get; set; }
    }
}
