using Microsoft.EntityFrameworkCore;
using RazorStudy.Model;

namespace RazorStudy
{
    //2 approaches:
    //1) Code First Approach
    //2) Database First Approach
    public class ApplicationDBContext : DbContext
    {
        string connectionString = @"server = DESKTOP-QG50OON\SQLEXPRESS;initial catalog = EFStudy; integrated security = true;TrustServerCertificate=True ";
        public DbSet<Student> Students { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlServer(connectionString);

    }
}
