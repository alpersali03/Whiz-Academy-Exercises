using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEx
{
    public class BankAccount
    {
        public int AccountNumber {  get; set; }
        public int Balance {  get; set; }
        public BankAccount(int accountNumber, int balance) 
        { 
            AccountNumber = accountNumber;  
            Balance = balance;  
        }    
    }
}
