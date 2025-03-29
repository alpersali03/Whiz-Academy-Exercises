using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Dog:WildAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }
}
