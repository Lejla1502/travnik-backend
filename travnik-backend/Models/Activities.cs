namespace travnik_backend.Models
{
    public class Activities
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Models.Event.Event>? Events { get; set; }
    }
}
