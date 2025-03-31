using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllingDevicesSystem
{
    public class Phone : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("The phone is on!");
        }
    }
}
