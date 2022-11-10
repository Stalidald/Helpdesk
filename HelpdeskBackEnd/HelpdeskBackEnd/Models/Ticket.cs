using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpdeskBackEnd.Models
{
    public class Ticket : BaseModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [ForeignKey("TicketDetails")]
        public long TicketDetailsId { get; set; }

        public virtual TicketDetails TicketDetails { get; set; }

        [ForeignKey("TicketStatus")]
        [Required]
        public long TicketStatusId { get; set; }

        public virtual TicketStatus TicketStatus { get; set; }

        [ForeignKey("User")]
        [Required]
        public long UserId { get; set; }

        public virtual User User { get; set; }

        public DateTime? PlannedClosedDate { get; set; }

        public DateTime? ClosedOn { get; set; }

    }
}
