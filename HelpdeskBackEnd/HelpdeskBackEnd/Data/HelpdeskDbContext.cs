using HelpdeskBackEnd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq.Expressions;

namespace HelpdeskBackEnd.Data
{
    public class HelpdeskDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketDetails> TicketDetails { get; set; }
        public DbSet<TicketStatus> TicketStatuses { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public HelpdeskDbContext(DbContextOptions<HelpdeskDbContext> options) : base(options) { }
  
    }
}
