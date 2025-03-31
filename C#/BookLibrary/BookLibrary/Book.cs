using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public abstract class Book
    {
        
        public string Author { get; set; }
        public string Title { get; set; }



        public abstract void Borrow();
        public abstract void Return();
    }
}
