using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartEngine
{
    public class Truck:Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("The truck is starting");
        }
    }
}
