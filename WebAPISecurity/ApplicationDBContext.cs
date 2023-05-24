
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAPISecurity.Model;

namespace WebAPISecurity
{
    public class ApplicationDBContext : IdentityUserContext<IdentityUser>
    {
        public DbSet<IPLPlayer> IPLPlayers { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }
}
