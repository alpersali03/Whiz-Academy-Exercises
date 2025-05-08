using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod
{
    public class CashPayment:IPaymentMethod
    {
        public override void Pay()
        {
            Console.WriteLine("You paid with Cash");
        }
    }
}
