using System.ComponentModel.DataAnnotations;

namespace HelpdeskBackEnd.Models
{
    public class UserRole : BaseModel
    {
        [Required]
        public string Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
