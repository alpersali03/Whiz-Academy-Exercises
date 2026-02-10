using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicsHub
{
    public class Producer
    {
        [Key]
        public int Id { get; set; } 
        public string ProducerName { get; set; }

        public string Pseudonym { get; set; }

        public string PhoneNumber { get; set; }

        public List<Producer> Albums { get; set; } = new List<Producer>();

    }
}
