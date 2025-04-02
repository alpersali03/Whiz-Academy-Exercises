using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToString
{
    public class Converter
    {
        public void ConvertToString(int number)
        {
            string str = number.ToString();
            Console.WriteLine(str);
        }
        public void ConvertToString(decimal number)
        {
            string str = $"{number:f2}";
            Console.WriteLine(str);
        }
    }
}
