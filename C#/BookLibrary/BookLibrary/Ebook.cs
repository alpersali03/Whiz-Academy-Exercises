using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Ebook : Book
    {
        public Ebook(string author, string title)
        {
            Author = author;
            Title = title;
            
        }
        public override void Borrow()
        {
            Console.WriteLine("Here's your installation link");
            
        }

        public override void Return()
        {
            Console.WriteLine("You returned a book");
            
        }
    }
}
