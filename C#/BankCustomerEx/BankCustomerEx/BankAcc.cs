using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustomerEx
{
    public class BankAcc
    {
        private string iban;
        private decimal balance;
        public string Iban
        {
            get
            {
                return iban;
            }
            set
            {
                iban = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
    }
}
