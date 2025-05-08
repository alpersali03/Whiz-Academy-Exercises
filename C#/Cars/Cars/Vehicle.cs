using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public abstract class Vehicle
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public int FuelLevel {  get; set; }


        public abstract void CalculateRange();
        
    }
}
