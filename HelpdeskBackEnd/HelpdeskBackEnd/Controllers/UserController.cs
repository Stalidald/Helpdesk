using HelpdeskBackEnd.Data;
using HelpdeskBackEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelpdeskBackEnd.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : BaseController<User, UserController>
    {
        public UserController(ILogger<UserController> logger, HelpdeskDbContext context) : base(logger, context)
        {
        }
    }
}
