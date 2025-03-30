using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEx
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(int accountNumber, int balance, int overdraftlimit) : base(accountNumber, balance)
        {
            Overdraftlimit = overdraftlimit;
        }
        public int Overdraftlimit {  get; set; }
        public void Withraw(int moneyForWithdraw)
        {
            int checkBalance = Balance - moneyForWithdraw;
            if (Overdraftlimit <= checkBalance )
            {
                Console.WriteLine("You can't withdraw money");

            }

            else
            {
                Balance -= moneyForWithdraw;
                Console.WriteLine($"{Balance}");
            }
        }
    }
    
}
