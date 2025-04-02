using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEx
{
    public class BusinessAccount : Account
    {
        public override void Deposit(double money)
        {
            Balance += money;
        }
    }
}
