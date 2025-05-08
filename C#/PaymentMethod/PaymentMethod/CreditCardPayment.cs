using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod
{
    public class CreditCardPayment:IPaymentMethod
    {
        public override void Pay()
        {
            Console.WriteLine("You used a credit card payment");
        }
    }
}
