using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    public class ProgrammingCourse : Course
    {
        public ProgrammingCourse(string title, string teacher) : base(title, teacher)
        {
        }
        public void DisplayCourseDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The course title is: {Title}");
            sb.AppendLine($"The teacsher is {Teacher}");
            sb.AppendLine($"The students are: {string.Join("--", Students)}");
            sb.AppendLine($"The contents are: {string.Join("--", Content)}");
            Console.WriteLine(sb.ToString());
        }
    }
}
