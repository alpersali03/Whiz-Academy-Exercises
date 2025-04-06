using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    public class Customer
    {
        [Key]
        public int Id { get; set; } 
        public string FullName { get; set; }

        public string Email {  get; set; }

        public string PhoneNumber { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();


    }
}
