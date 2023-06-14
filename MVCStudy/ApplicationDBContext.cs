using Microsoft.EntityFrameworkCore;
using MVCStudy.Models;

namespace MVCStudy
{
    public class ApplicationDBContext : DbContext
    {

        public DbSet<IPLPlayer> iplPlayer { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }
}
