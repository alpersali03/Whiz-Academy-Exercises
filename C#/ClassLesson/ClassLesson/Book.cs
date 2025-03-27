using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson
{
    public class Book
    {
        private int year;
        private string author;
        private string title;
        public string Title
        {

            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
    }
}
