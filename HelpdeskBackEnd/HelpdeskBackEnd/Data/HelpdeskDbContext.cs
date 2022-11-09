using HelpdeskBackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace HelpdeskBackEnd.Data
{
    public class HelpdeskDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketDetails> TicketDetails { get; set; }

        public HelpdeskDbContext(DbContextOptions<HelpdeskDbContext> options) : base(options) { }

    }
}
