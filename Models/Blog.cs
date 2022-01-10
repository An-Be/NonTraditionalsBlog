using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NonTraditionalsBlog.Models
{
    public class Blog
    {
        public int Id { get; set; }
        //[Required]
        [DisplayName("User Name")]
        public string? UserName { get; set; }
        public string? Title { get; set; }
        [Required]
        public string? Content { get; set; } 
        [Required]
        [DisplayName("Time Stamp")]
        public DateTime TimeStamp { get; set; }
    }
}
