using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTransport
{
    public class Car:Transport
    {
        public override void GetType()
        {
            Console.WriteLine("Car");
        }
    }
}
