using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramowrkHomework
{
    public class AppDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            // modelBuilder.Entity<Employee>()
            //             .HasOne(e=>e.Manager)
            //             .WithMany(m=> m.Subordinates)
            //             .HasForeignKey(e=>e.ManagerId)
            //             .OnDelete(DeleteBehavior.ClientNoAction);
                        
         //   base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AUT50J3;Database=WhizEntity;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Employee> Employees{ get;set;}
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
    }
}
