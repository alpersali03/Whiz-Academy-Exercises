using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramowrkHomework
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [StringLength(50)]
        public string DepartmentName { get; set; }

        public int ManagerId { get; set; }
        [ForeignKey("ManagerId")]
        public Employee Employee { get; set; }
    }
}
