using System.Text.Json.Serialization;

namespace travnik_backend.Models
{
    public class TopLevelFeatures
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Models.Accomodation.Accomodation>? Accomodations { get; set; }
        public List<AccomodationRoomName> AccomodationRoomNames { get; set; }
    }
}
