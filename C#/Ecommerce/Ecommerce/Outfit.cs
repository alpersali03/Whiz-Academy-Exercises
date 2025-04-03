using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Outfit:Product
    {
        public Outfit(string name, int price) : base(name, price)
        {
        }
        public Outfit(int size, string name, int price) : base(name, price)
        {
            Size = size;
        }

        public int Size { get; set; }
         
    }
}
