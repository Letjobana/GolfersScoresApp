using GolfersAppliaction.Models;
using Microsoft.EntityFrameworkCore;

namespace GolfersAppliaction.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Player> Players { get; set; }
    }
}
