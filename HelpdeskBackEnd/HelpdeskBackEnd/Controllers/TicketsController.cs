using HelpdeskBackEnd.Data;
using HelpdeskBackEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelpdeskBackEnd.Controllers
{
    [ApiController]
    [Route("api/ticket")]
    public class TicketsController : BaseController<Ticket, TicketsController>
    {
        public TicketsController(HelpdeskDbContext context, ILogger<TicketsController> logger) : base(logger, context)
        {
        }
    }
}
