using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    public class BankAccount
    {
        public string AccountHolder {  get; set; }
        public decimal Balance {  get; set; }
        public int AccountNumber {  get; set; }

        public BankAccount(int accountNumber, decimal balance, string accountHolder)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            AccountHolder = accountHolder;

        }
        
        
        public void Withdraw(decimal amount)
        {
            //decimal checkBalance = Balance - amount;

            if (this.Balance < amount || amount < 0)
            {
                throw new ArgumentNullException("You can't withdraw money");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Current balance is {Balance}");
            }
        }


        public void TransferFundsTo(decimal amount)
        {
            this.Balance += amount;
        }


        public decimal GetBalance()
        {
            return Balance;
        }


        public void TransferFundsTo(BankAccount otherAccount, decimal amount)
        {
            if (otherAccount is null || this.Balance < amount || amount < 0)
            {
                throw new ArgumentNullException("You can't send money");
            }

            Withdraw(amount);
            otherAccount.Balance += amount;
        }

        public bool Overdrawn()
        {
            if(Balance < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
