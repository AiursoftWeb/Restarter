using Microsoft.EntityFrameworkCore;
using Restarter.Models;

namespace Restarter.Data
{
    public class RestarterDbContext : DbContext
    {
        public RestarterDbContext(DbContextOptions<RestarterDbContext> options) : base(options)
        {
        }
        public DbSet<Server> Servers { get; set; }
    }
}