using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Ebook:Book
    {
        public override void GetDetails()
        {
            Console.WriteLine("Electronic book");
        }
    }
}
