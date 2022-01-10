using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace NonTraditionalsBlog.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string? Name { get; set; }
    }
}
