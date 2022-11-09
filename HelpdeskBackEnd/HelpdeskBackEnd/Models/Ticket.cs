using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpdeskBackEnd.Models
{
    public class Ticket
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public TicketDetails Details { get; set; }
        public long CreatedBy { get; set; }
        public long DepartmentId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime PlannedClosedDate { get; set; }
        public DateTime ClosedOn { get; set; }

    }
}
