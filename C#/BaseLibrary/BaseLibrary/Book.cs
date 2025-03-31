using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary
{
    public class Book
    {
        public virtual void GetDetails()
        {
            Console.WriteLine("Main info about the book");
        }
    }
}
