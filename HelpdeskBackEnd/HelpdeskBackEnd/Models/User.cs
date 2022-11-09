using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace HelpdeskBackEnd.Models
{
    public class User : BaseModel
    {

        [ForeignKey("Department")]
        public long DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string UserName { get; set; }

        [ForeignKey("UserRole")]
        public long UserRoleId { get; set; }

        public virtual UserRole UserRole { get; set; } 

        [Required]
        public string Email { get; set; }
    }
}
