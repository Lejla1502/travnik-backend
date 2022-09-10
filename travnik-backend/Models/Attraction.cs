using System.Text.Json.Serialization;

namespace travnik_backend.Models
{
    public class Attraction
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Season { get; set; }
        [JsonIgnore]
        public List<Activities>? Activities { get; set; }
    }
}
