using System.ComponentModel.DataAnnotations;

namespace HelpdeskBackEnd.Models
{
    public class Department
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty; 
    }
}
