using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public class Employee
    {
        public Employee(decimal salary, string name)
        {
            Salary = salary;
            Name = name;
        }

        public decimal Salary {  get; set; }    
        public string Name { get; set; }

    }
}
