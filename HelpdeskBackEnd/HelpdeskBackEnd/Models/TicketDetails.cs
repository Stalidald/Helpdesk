using System.ComponentModel.DataAnnotations;

namespace HelpdeskBackEnd.Models
{
    public class TicketDetails : BaseModel
    {

        [Required]
        public long TicketId { get; set; }

        public string Joke { get; set; }
    }
}
