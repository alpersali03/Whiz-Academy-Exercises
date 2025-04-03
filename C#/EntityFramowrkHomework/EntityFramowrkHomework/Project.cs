using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramowrkHomework
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [StringLength(50)]  
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(30)]
        public string StartDate { get; set; }

        [StringLength(30)]
        public string EndDate { get; set; }

    }
}
