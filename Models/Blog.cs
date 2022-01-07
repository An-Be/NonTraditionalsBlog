namespace NonTraditionalsBlog.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
