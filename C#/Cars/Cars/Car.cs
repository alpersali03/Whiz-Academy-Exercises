using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car:Vehicle
    {
        public Car(string make, string model, int fuelLevel, int kilometers)
        {
            Make = make; 
            Model = model; 
            FuelLevel = fuelLevel;
            
        }

        public override void CalculateRange()
        {
            throw new NotImplementedException();
        }
    }
}
