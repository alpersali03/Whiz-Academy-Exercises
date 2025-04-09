using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
    public class AppDbContext : DbContext
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
                new Student { Id = 5, Name = "Eve" },
                new Student { Id = 6, Name = "Frank" },
                new Student { Id = 7, Name = "Grace" },
                new Student { Id = 8, Name = "Hank" },
                new Student { Id = 9, Name = "Ivy" },
                new Student { Id = 10, Name = "Jack" },
                new Student { Id = 11, Name = "Kim" },
                new Student { Id = 12, Name = "Liam" },
                new Student { Id = 13, Name = "Mia" },
                new Student { Id = 14, Name = "Nathan" },
                new Student { Id = 15, Name = "Olivia" },
                new Student { Id = 16, Name = "Peter" },
                new Student { Id = 17, Name = "Quinn" },
                new Student { Id = 18, Name = "Rachel" },
                new Student { Id = 19, Name = "Steve" },
                new Student { Id = 20, Name = "Tina" },
                new Student { Id = 21, Name = "Alper" }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Title = "Math" },
                new Course { Id = 2, Title = "History" },
                new Course { Id = 3, Title = "Science" },
                new Course { Id = 4, Title = "Programming" },
                new Course { Id = 5, Title = "Art" },
                new Course { Id = 6, Title = "Bulgarian language" },
                new Course { Id = 7, Title = "Physics" },
                new Course { Id = 8, Title = "Chemistry" },
                new Course { Id = 9, Title = "Biology" },
                new Course { Id = 10, Title = "Music" },
                new Course { Id = 11, Title = "Philosophy" },
                new Course { Id = 12, Title = "Economics" },
                new Course { Id = 13, Title = "Sports" },
                new Course { Id = 14, Title = "English" },
                new Course { Id = 15, Title = "French" },
                new Course { Id = 16, Title = "German" },
                new Course { Id = 17, Title = "Geography" },
                new Course { Id = 18, Title = "Psychology" }
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
                new Enrollment { Id = 10, StudentId = 5, CourseId = 5 },
                new Enrollment { Id = 11, StudentId = 6, CourseId = 6 },
                new Enrollment { Id = 12, StudentId = 6, CourseId = 7 },
                new Enrollment { Id = 13, StudentId = 7, CourseId = 8 },
                new Enrollment { Id = 14, StudentId = 7, CourseId = 9 },
                new Enrollment { Id = 15, StudentId = 8, CourseId = 10 },
                new Enrollment { Id = 16, StudentId = 8, CourseId = 11 },
                new Enrollment { Id = 17, StudentId = 9, CourseId = 12 },
                new Enrollment { Id = 18, StudentId = 9, CourseId = 13 },
                new Enrollment { Id = 19, StudentId = 10, CourseId = 14 },
                new Enrollment { Id = 20, StudentId = 10, CourseId = 15 },
                new Enrollment { Id = 21, StudentId = 11, CourseId = 16 },
                new Enrollment { Id = 22, StudentId = 11, CourseId = 17 },
                new Enrollment { Id = 23, StudentId = 12, CourseId = 18 },
                new Enrollment { Id = 24, StudentId = 12, CourseId = 1 },
                new Enrollment { Id = 25, StudentId = 13, CourseId = 2 },
                new Enrollment { Id = 26, StudentId = 13, CourseId = 3 },
                new Enrollment { Id = 27, StudentId = 14, CourseId = 4 },
                new Enrollment { Id = 28, StudentId = 14, CourseId = 5 },
                new Enrollment { Id = 29, StudentId = 15, CourseId = 6 },
                new Enrollment { Id = 30, StudentId = 15, CourseId = 7 },
                new Enrollment { Id = 31, StudentId = 16, CourseId = 8 },
                new Enrollment { Id = 32, StudentId = 16, CourseId = 9 },
                new Enrollment { Id = 33, StudentId = 17, CourseId = 10 },
                new Enrollment { Id = 34, StudentId = 17, CourseId = 11 },
                new Enrollment { Id = 35, StudentId = 18, CourseId = 12 },
                new Enrollment { Id = 36, StudentId = 18, CourseId = 13 },
                new Enrollment { Id = 37, StudentId = 19, CourseId = 14 },
                new Enrollment { Id = 38, StudentId = 19, CourseId = 15 },
                new Enrollment { Id = 39, StudentId = 20, CourseId = 16 },
                new Enrollment { Id = 40, StudentId = 20, CourseId = 17 },
                new Enrollment { Id = 41, StudentId = 21, CourseId = 18 }
            );
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

    }
}
