

using Microsoft.EntityFrameworkCore;
using SchoolProgram;

using var context = new AppDbContext();

// context.Database.EnsureDeleted(); - iztriwa bazata rychno 
// context.Database.EnsureCreated(); - syzdawa bazata rychno 

//1. List all students who are enrolled in at least one course.


var students = context.Students
.Include(s => s.Enrollments)
.Where(e => e.Enrollments.Count > 0)
.ToList();

var studentsInProgramming = context.Students.
    Where(s => s.Enrollments.
    Any(e => e.Course.Name == "Programming")).ToList();


var studentsWithTwoCourses = context.Students
.Where(s=> s.Enrollments
.Any(e=>e.Course.Count > 2))
.ToList();

var emptyCourses = context.Students.Include(s => s.Enrollments).Where(e=>e.Enrollments.Count = 0).ToList();

var mathAndScience = context.Students.
    Where(s => s.Enrollments.
    Any(e => e.Course.Name == "Math" and e => e.Course.Name = "Science")).ToList();

var anyEnrollments = context.Students.Include(s = s => s.Enrollments.Count).Tolist();