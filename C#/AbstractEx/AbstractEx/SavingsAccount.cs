using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEx
{
    public class SavingsAccount : Account
    {
        

        public override void Deposit(double money)
        {
            Balance += money;
        }
    }
}
