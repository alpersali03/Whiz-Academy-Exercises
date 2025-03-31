using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllingAnimalsSystem
{
    internal class Lion:Carnivore
    {
        public override void Eat()
        {
            Console.WriteLine("Lion eats meat");
        }
    }
}
