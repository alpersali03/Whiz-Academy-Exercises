using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    public class CarInfoClass
    {
        private string make;
        private int speed;

        public CarInfoClass(string make, int speed)
        {
            this.Make = make;
            this.Speed = speed;
        }
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Make: " + this.Make);
            Console.WriteLine("Speed: " + this.Speed);
           
        }
    }
}
