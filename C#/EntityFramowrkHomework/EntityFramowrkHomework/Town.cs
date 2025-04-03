using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramowrkHomework
{
    public class Town
    {
        public int TownId { get; set; }
        public string Name { get; set; }
 
        public List<Address> Addresses {get;set;} = new List<Address>(); // Adres Adres       
    }
}
