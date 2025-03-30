using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public class Manager : Employee
    {
        public Manager(decimal salary, string name, string department) : base(salary, name)
        {
            Department = department;
        }
        public string Department {  get; set; }
        public void ManagerInfo()
        {
            Console.WriteLine($"Мениджър: {Name}, заплата: {Salary}, отдел: {Department}");
        }

    }
}
