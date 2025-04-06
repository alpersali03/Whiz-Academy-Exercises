using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    public class Order
    {
        [Key]
        public int Id {  get; set; }

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]

        public Customer Customers { get; set; }
        public DateTime OrderDate { get; set; }

        public decimal TotalAmount {  get; set; }

    }
}
