using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SchoolProject;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
              new Student { Id = 1, Name = "Alice" },
              new Student { Id = 2, Name = "Bob" },
              new Student { Id = 3, Name = "Charlie" },
              new Student { Id = 4, Name = "David" },
              new Student { Id = 5, Name = "Eve" }
          );

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Title = "Math" },
                new Course { Id = 2, Title = "History" },
                new Course { Id = 3, Title = "Science" },
                new Course { Id = 4, Title = "Programming" },
                new Course { Id = 5, Title = "Art" }
            );

            modelBuilder.Entity<Enrollment>().HasData(
                new Enrollment { Id = 1, StudentId = 1, CourseId = 1 },
                new Enrollment { Id = 2, StudentId = 1, CourseId = 2 },
                new Enrollment { Id = 3, StudentId = 2, CourseId = 1 },
                new Enrollment { Id = 4, StudentId = 2, CourseId = 3 },
                new Enrollment { Id = 5, StudentId = 3, CourseId = 2 },
                new Enrollment { Id = 6, StudentId = 3, CourseId = 4 },
                new Enrollment { Id = 7, StudentId = 4, CourseId = 3 },
                new Enrollment { Id = 8, StudentId = 4, CourseId = 5 },
                new Enrollment { Id = 9, StudentId = 5, CourseId = 4 },
                new Enrollment { Id = 10, StudentId = 5, CourseId = 5 }
            );
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

    }
}
