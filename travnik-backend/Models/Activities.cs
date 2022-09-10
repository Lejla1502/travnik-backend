using System.Text.Json.Serialization;

namespace travnik_backend.Models
{
    public class Activities
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        [JsonIgnore]
        public List<Models.Event.Event>? Events { get; set; }

        public List<Attraction> Attractions { get; set; }
    }
}
