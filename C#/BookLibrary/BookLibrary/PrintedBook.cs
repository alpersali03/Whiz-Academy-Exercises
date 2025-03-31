using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class PrintedBook : Book
    {
        public PrintedBook(string author, string title, int bookCount)
        {
            Author = author;
            Title = title;  
            BookCount = bookCount;  
        }
        public int BookCount { get; set; }
        public override void Borrow()
        {
            Console.WriteLine("Here's your installation link");
            BookCount--;
        }

        public override void Return()
        {
            Console.WriteLine("You returned a book");
            BookCount ++;
        }
    }
}
