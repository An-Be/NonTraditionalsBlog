using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NonTraditionalsBlog.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Content { get; set; } 
        [Required]
        [DisplayName("Time Stamp")]
        public DateTime TimeStamp { get; set; }
    }
}
