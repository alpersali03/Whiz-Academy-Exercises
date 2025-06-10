using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    public abstract class Employee
    {
        public string Name {  get; set; }
        public int Age { get; set; }

        public double Salary { get; set; }
        public void DisplayDetails()
        {
            Console.WriteLine(Name, Age, Salary);
        }
    }
}
