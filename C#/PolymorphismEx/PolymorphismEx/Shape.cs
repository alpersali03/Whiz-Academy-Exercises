using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismEx
{
    public class Shape
    {
        public void CalculateArea(int sidelength)
        {
            Console.WriteLine(sidelength * sidelength);
        }
        public void CalculateArea(int length, int width)
        {
            Console.WriteLine(length * width);
        }
    }
}
