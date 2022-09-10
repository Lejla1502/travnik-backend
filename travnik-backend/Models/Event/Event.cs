using System.Text.Json.Serialization;

namespace travnik_backend.Models.Event
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public DateTime DateOfEvent { get; set; }
        public string Text { get; set; }
        public string Location { get; set; }
        public double? Fee { get; set; }


        public int OrganizerId { get; set; }

        public Organizer Organizer { get; set; }
        [JsonIgnore]
        public int? ActivitiesId { get; set; }
        public Activities Activities { get; set; }

    }
}
