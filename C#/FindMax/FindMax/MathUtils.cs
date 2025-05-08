using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMax
{
    public class MathUtils
    {
        public void FindMax(int first, int second)
        {
            if (first > second)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }

        }
        public void FindMax(int first, int second, int third)
        {
            if (first > second && first > third)
            {
                Console.WriteLine(first);
            }
            else if (second > first && second > third) 
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine(third);
            }

        }

    }
}
