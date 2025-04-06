using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    public class CreditCardPayment : IPaymentMethod, IDeposit
    {
        public void Deposit()
        {
            throw new NotImplementedException();
        }

        public void Pay()
        {
            Console.WriteLine("Payment in card");
        }
    }
}
