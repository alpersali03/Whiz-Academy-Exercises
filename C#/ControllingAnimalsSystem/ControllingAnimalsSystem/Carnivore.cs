using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllingAnimalsSystem
{
    internal class Carnivore : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eats meat");
        }
    }
}
