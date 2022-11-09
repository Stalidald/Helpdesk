using System.ComponentModel.DataAnnotations;

namespace HelpdeskBackEnd.Models
{
    public class User
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
    }
}
