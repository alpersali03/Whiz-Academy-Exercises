using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    public class FullTimeEmployee:Employee
    {
        public FullTimeEmployee(string name, int age, double salary)
        {
            Name = name;
            Age = age;  
            Salary = salary;
        } 
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Monthly Salary: ${Salary}");
        }
    }
}
