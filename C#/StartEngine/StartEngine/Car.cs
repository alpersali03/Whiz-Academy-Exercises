using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartEngine
{
    public class Car:Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("The car is starting");
        }
    }
}
