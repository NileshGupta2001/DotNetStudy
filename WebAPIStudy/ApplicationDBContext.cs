using Microsoft.EntityFrameworkCore;
using WebAPIStudy.Model;

namespace WebAPIStudy
{
    public class ApplicationDBContext : DbContext
    {
        
        public DbSet<Doctor> Doctors { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }
}
