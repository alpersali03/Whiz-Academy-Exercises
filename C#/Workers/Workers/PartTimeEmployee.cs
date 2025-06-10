using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    internal class PartTimeEmployee:Employee
    {
        public PartTimeEmployee(string name, int age, double hourlySalary, int hours) 
        { 
            Name = name;
            Age = age;  
            HourlySalary = hourlySalary;
            Hours = hours;
        }   
        public double HourlySalary { get; set; }
        public int Hours {  get; set; }
        public void DisplayDetails()
        {
            double calculate = Hours * HourlySalary;
            Console.WriteLine($"Name: {Name}, Age: {Age}, Total Earnings: ${calculate}");
        }
    }
}
