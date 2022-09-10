namespace travnik_backend.Models
{
    public class Attraction
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Season { get; set; }
        public List<Activities> Activities { get; set; }
    }
}
