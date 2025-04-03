using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Cart:IPaymentMethod
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void Pay()
        {

            // double total sum 
            // foreach 

            // product.price

            // cw total price
        }
    }
}
