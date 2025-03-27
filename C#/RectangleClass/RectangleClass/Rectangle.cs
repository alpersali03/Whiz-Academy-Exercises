using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleClass
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle(int length, int width)
        {
            this.Length = length;
            this.Width = width;
        }
        public int Length 
        { 
            get 
            { 
                return length;
            }
            set
            {
                length = value;
            }
        }
        public int Width 
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public int RectangleArea()
        {
            return this.Width * this.Length;
        }
    }
}
