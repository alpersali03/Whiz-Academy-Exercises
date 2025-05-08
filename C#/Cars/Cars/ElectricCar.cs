using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class ElectricCar:Vehicle
    {
        public ElectricCar(string make, string model, int fuelLevel, int kilometers)
        {
            Make = make;
            Model = model;
            FuelLevel = fuelLevel;
            
        }
        public int Kilometers
        public override void CalculateRange()
        {
            throw new NotImplementedException();
        }
    }
}
