using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllingAnimalsSystem
{
    public class Herbivore : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eats grass");
        }
    }
}
