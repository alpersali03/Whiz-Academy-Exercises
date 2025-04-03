using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLesson
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AUT50J3;Database=TestingCodeFirst;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Animal> Animals { get; set; }
    }
     
}
