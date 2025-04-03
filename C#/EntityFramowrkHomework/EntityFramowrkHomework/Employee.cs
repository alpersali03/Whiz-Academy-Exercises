using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramowrkHomework
{
    public class Employee
    {
        [Key]

        public int Id { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public string JobTitle { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        // public int ManagerId { get; set; }
        // [ForeignKey("ManagerId")]
        // public Employee Manager { get; set; }
        // public IList<Employee> Subordinates {get;set;}

        public string HireDate { get; set; }

        public int Salary { get; set; }

        public int AdressId { get; set; }
        public Address Address { get; set; }
    }
}
