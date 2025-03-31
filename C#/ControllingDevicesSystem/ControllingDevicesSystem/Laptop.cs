using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllingDevicesSystem
{
    public class Laptop : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("The laptop is on");
        }
    }
}
