using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    public abstract class Course
    {
        public string Title { get; set; }
        public string Teacher { get; set; }
        public List <string> Content { get; set; } = new List<string>();
        public List <string> Students { get; set; } = new List<string>();
        public Course(string title, string teacher) 
        {
            Title = title;
            Teacher = teacher;
        }
        public void AddContent(string content)
        {
            Content.Add(content);
        }
        public void EnrollStudent(string student)
        {
            Students.Add(student);
        }


    }
}
