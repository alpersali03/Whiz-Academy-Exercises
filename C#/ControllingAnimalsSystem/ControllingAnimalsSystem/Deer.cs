using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllingAnimalsSystem
{
    public class Deer:Herbivore
    {
        public override void Eat()
        {
            Console.WriteLine("Deer eats grass");
        }
    }
}
