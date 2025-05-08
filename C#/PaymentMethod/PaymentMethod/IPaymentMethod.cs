using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod
{
    public class IPaymentMethod
    {
        public virtual void Pay()
        {
            Console.WriteLine("Choose a payment method");
        }
    }
}
