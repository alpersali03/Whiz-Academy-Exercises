using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc.Test
{
    
    public class BankAccTests
    {
        private BankAccount bankAcc;
        
        //
        [SetUp]
        public void Setup(){
            this.bankAcc = new BankAccount(44444444, 10000, "Apli Sigma");
        }

        [Test]
        public void GetBalanceShouldReturnCorrectBalance()
        {
            // Arrange
            decimal expectedResult = 10000;

            // Act
            decimal result = this.bankAcc.GetBalance();

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "Balance result is correct.");

        }
        [Test]
        public void GetBalanceShouldNotReturnCorrectResult()
        {
            // Arrange
            decimal expectedResult = 1000000;

            // Act
            decimal result = this.bankAcc.GetBalance();

            // Assert
            Assert.That(result, Is.Not.EqualTo(expectedResult), "Balance result does not return correct result.");

        }
        [Test]
        public void DepositShouldAddCorrectlyBalance()
        {
            // Arrange
            int expectedResult = 11000;
            int deposit = 1000;

            // Act
            this.bankAcc.TransferFundsTo(deposit);
            decimal result = this.bankAcc.GetBalance();


            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "Successful deposit.");

        }

        [Test]
        public void WithdrawShouldReturnExceptionBecauseNotEnoughMoney()
        {
            // Arrange
            int withdraw = 15000;
            //int expectedResult = 11000;

            // Act
            // this.bankAcc.Deposit(withdraw);
            // // decimal result = this.bankAcc.GetBalance();


            // Assert
            //Assert.That(result, Is.EqualTo(expectedResult), "Successful deposit.");
            Assert.Throws<ArgumentNullException>(() => this.bankAcc.Withdraw(withdraw));
            
        }
        [Test]  
        public void TrnasferShouldSendCorrectlyIntoBalance()
        {
            // Arrange
            var senderAccount = new BankAccount(44444444, 10000, "Apli Sigma");  
            var recipientAccount = new BankAccount(11111111, 20000, "Ivan Sigma"); ;
            decimal transferAmount = 1000;
            decimal expectedSenderBalance = 9000;
            decimal expectedRecipientBalance = 21000;

            // Act
            senderAccount.TransferFundsTo(recipientAccount, transferAmount);
            decimal senderResult = senderAccount.Balance;
            decimal recipientResult = recipientAccount.Balance;


            // Assert
            Assert.That(senderResult, Is.EqualTo(expectedSenderBalance), "Successful transfer.");
            Assert.That(recipientResult, Is.EqualTo(expectedRecipientBalance), "You got a new amount into your account");
        }

        [Test]
        public void IsOverdrawnShouldReturnTrueIfBalanceIsNegative()
        {
            // Arrange
            var account = new BankAccount(11111111, -20000, "Ivan Sigma"); ;
            const bool isOverdrawn = true;
            
            // Act
            bool isOverdrawnAcc = account.Overdrawn();
            

            // Assert
            Assert.That(isOverdrawn, Is.EqualTo(isOverdrawnAcc), "Yes, the acc is overdrawned");
        }
              [Test]
        public void IsOverdrawnShouldReturnFalseIfBalanceIsPositive()
        {
            // Arrange
            const bool isOverdrawn = false;
            
            // Act
            bool isOverdrawnAcc = this.bankAcc.Overdrawn();
            

            // Assert
            Assert.That(isOverdrawn, Is.EqualTo(isOverdrawnAcc), "Yes, the acc NOT is overdrawned");
        }
    }
}
