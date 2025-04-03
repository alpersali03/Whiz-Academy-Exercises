using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Electronics:Product
    {
       
        public Electronics(string name, int price) : base(name, price)
        {

        }
        public Electronics(string bestDate, string name, int price) : base(name, price)
        {
            BestDate = bestDate;
        }

        public string BestDate {  get; set; }
        
    }
}
