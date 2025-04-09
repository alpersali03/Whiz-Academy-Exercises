

using Microsoft.EntityFrameworkCore;
using SchoolProgram;
using System;

using var context = new AppDbContext();

context.Database.EnsureDeleted(); // - iztriwa bazata rychno 
context.Database.EnsureCreated(); // - syzdawa bazata rychno 

//1. List all students who are enrolled in at least one course.

// var students = context.Students
// .Include(s => s.Enrollments)
// .Where(e => e.Enrollments.Count > 0)
// .ToList();



// 02. Find all students enrolled in "Programming".
//var studentsInProgramming = context.Students
//    .Include(s => s.Enrollments)
//    .ThenInclude(c => c.Course)
//    .Where(x => x.Enrollments.Any(e => e.Course.Title == "Programming"))
//    .ToList();




Enrollment enr = new Enrollment();
 enr.StudentId = 5;
 enr.CourseId = 5;
 context.Enrollments.Add(enr);
enr.CourseId = 1;
 context.Enrollments.Add(enr);

 context.SaveChanges();

//var studentsCountInCourses = context.Courses.Include(s => s.Enrollments).ToList();
//foreach (var currentCourse in studentsCountInCourses)
//{
//    Console.WriteLine($"The course {currentCourse.Title} is enrolled {currentCourse.Enrollments.Count()} times");
//}

//var studentsWithTwoCourses = context.Students.Include(s => s.Enrollments).Where(x=>x.Enrollments.Count > 2).ToList();

//var emptyCourse = context.Courses.Include(c => c.Enrollments).Where(x => x.Enrollments.Count == 0).ToList();

//var mathAndScience = context.Students
//    .Where(s => s.Enrollments.Any(e => e.Course.Title == "Math") &&
//                s.Enrollments.Any(e => e.Course.Title == "Science"))
//    .ToList();

//7.
//var studentEnrollments = context.Students.Include(s => s.Name).ThenInclude(e => e.Enrollments.Count);

//foreach (var enrollment in studentEnrollments)
//{
//    Console.WriteLine($"The student {enrollment.Name} is enrolled in {enrollment.Enrollments.Count} courses.");
//}

// 1. Get all student's names
//var studentNames = context.Students.Select(s => s.Name).ToList();

// 2. Get all course titles

//var courseTitles = context.Courses.Select(c => c.Title).ToList();

// 3. Find all students enrolled in any course

//var enrolledInAnyCourse = context.Students
//    .Include(s => s.Enrollments)
//    .ThenInclude(c => c.Course)
//    .ToList();

// 4. Count how many students exist.

//var studentsCount = context.Students.Count();

// 5. Students who are nit enrolled in a course

//var studentsWhoAreNotEnrolled = context.Students.Include(s => s.Enrollments).
//Where(e => e.Enrollments.Count == 0).ToList();

// 6. Retrieve the latest 3 enrollments (most recent ones).
//var recentEnrollments = context.Enrollments.OrderBy(x=> x.Id).Take(3).ToList();

// 7. Find the top 2 most popular courses based on enrollment count.

//var mostPopularCourses = context.Courses.Include(c => c.Enrollments).OrderByDescending(x=>x.Enrollments.Count).Take(2).ToList();


//8. List all courses with their students (even if no students are enrolled).

//var coursesWithStudents = context.Courses.Include(c => c.Enrollments).ThenInclude(e => e.Student).ToList();
//foreach (var currentCourse in coursesWithStudents)
//{
//    Console.WriteLine($"Courses: The course is {currentCourse.Title} ");
//    foreach (var currentEnrl in currentCourse.Enrollments)
//    {
//        Console.WriteLine($"Enrolled user is: {currentEnrl.Student.Name}");
//    }   

//}

// 9. Get the student who is enrolled in the most courses.

//var studentWhoIsEnrolledInTheMostCourses = context.Students
//                                                            .Include(s => s.Enrollments)
//                                                            .OrderByDescending(x=>x.Enrollments.Count)
//                                                            .Take(1).ToList();

//1.Get all Student's names
//var allStudentsNames = context.Students.Select(s=>s.Name).ToList();

//2. Get all course titles.
//var courseTitles = context.Courses.Select(c => c.Title).ToList();

// 3. Find all students who are enrolled in any course
var enrolledInAnyCourse = context.Students.Include(s=>s.Enrollments).ThenInclude(c=>c.Course).Where(x=>x.Enrollments.Count() > 0).ToList();

//4.Count how many students exist.
var studentsCount = context.Students.Count();

//5.Find a specific student by name ("Alice").
var findByName = context.Students.FirstOrDefault(s => s.Name == "Alice");

//6.Get all studets sorted by ascending order
var allStudentsSortedAsc = context.Students.OrderBy(s=>s.Name).ToList();

//7.Find the first 3 courses in the database
var firstThreeCourses = context.Courses.OrderBy(c => c.Id).Take(3).ToList();

//8.Find students who are only enrolled in one course.
var studentsEnrolledInOneCourse = context.Students
                                               .Include(s => s.Enrollments)
                                                .Where(x => x.Enrollments.Count == 1).ToList();

//9. Count the total number of enrollments in the system.
var totalEnrollemnts = context.Enrollments.Count();

// DONE 10. Find the most enrolled student
var mostEnrolledStud = context.Students
                                      .Include(s=>s.Enrollments)
                                      .OrderByDescending(x => x.Enrollments.Count)
                                      .Take(1).ToList();

//11.Find the students who are enrolled in all available courses
//var totalCourses = context.Courses.Count();

//var nerdyStudents = context.Students
//    .Include(s => s.Enrollments)
//    .Where(s => s.Enrollments.Count() == totalCourses)
//    .ToList();

// 12. Get the average number of courses per student and filter students above this average.

var avgCourses = context.Students.Select(s=>s.Enrollments.Count).Average();
var studentsAboveAverage = context.Students.Where(x => x.Enrollments.Count() >= avgCourses).ToList();

//13.Find students who are enrolled in at least two different courses taught by the same professor (if professors were added).

;