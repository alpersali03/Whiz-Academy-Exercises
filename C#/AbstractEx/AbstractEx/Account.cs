using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEx
{
    public abstract class  Account
    {
        public double Balance { get; set; }    
        public abstract void Deposit(double money);

    }
}
