using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerStudy.Model;

namespace DataAccessLayerStudy
{
    //2 approaches:
    //1) Code First Approach
    //2) Database First Approach
    public class ApplicationDBContext:DbContext
    {
        string connectionString = @"server = DESKTOP-QG50OON\SQLEXPRESS;initial catalog = EFStudy; integrated security = true;TrustServerCertificate=True ";
        DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(connectionString);

    }
}
