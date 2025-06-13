using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaySound
{
    public class Drum : IMusicalInstrument
    {
        public void PlaySound()
        {
            Console.WriteLine("Plays drum");
        }
    }
}
