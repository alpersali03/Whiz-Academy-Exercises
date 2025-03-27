using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustomerEx
{
    public class BankCustomer
    {
        private string name;
        private int bankAccount1; 
        private int bankAccount2; 

        public BankCustomer(string name)
        {
            this.Name = name;
            Accounts =  new List<BankAcc>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            set 
            { 
                name = value;
            }
        }
        
        public List<BankAcc> Accounts {get;set;} 

        public decimal GetTotalBalance()
        {
            Accounts.Sum(x => x.Balance);
            return Accounts.Sum(x => x.Balance);
        }

    }
}
