using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplianceInheritence
{
    public class Appliance
    {
        public Appliance(string brand, int power)
        {
            Brand = brand;
            Power = power;
        }
        public string Brand { get; set; }
        public int Power { get; set; }

    }
}
