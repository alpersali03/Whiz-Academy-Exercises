using BankCustomerEx;

BankAcc  acc1 = new BankAcc();
acc1.Iban = "1212234321";
acc1.Balance = 20000;
BankCustomer Alper = new BankCustomer("Alper");
Alper.Accounts.Add(acc1);
Console.WriteLine(acc1.Balance);