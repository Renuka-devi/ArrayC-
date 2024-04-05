using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class BankAccount
    {
        public string AccountNumber;
        public string AccountHolderName;
        protected double balance;

        public double Balance { get => balance; set => balance = value; }

        public BankAccount(string AccountNumber, string AccountHolderName)
        {

        }

        public abstract void deposit();

        public abstract void withdraw();

        public void displayBalance()
        {
            Console.WriteLine("Balance is: " + Balance);
        }
    }
    class SavingsAccount : BankAccount
    {
        public string intrestRate = "7%";
        public SavingsAccount(string AccountNumber, string AccountHolderName) : base(AccountNumber, AccountHolderName)
        {

        }

        public override void deposit()
        {

        }

        public override void withdraw()
        {
            
        }

        public void interestOfBalance()
        {
            double intrest;
            intrest = Balance * (7 / 100);
            double CurrentBalance = Balance + intrest;
            Console.WriteLine("adding current balance and interest: " + CurrentBalance);
            //return CurrentBalance;
        }
    }

    class CurrentAccount : BankAccount
    {
        public double overdraftlimit;
        public CurrentAccount(string AccountNumber, string AccountHolderName) : base(AccountNumber, AccountHolderName)
        {

        }

        public override void deposit()
        {

        }

        public override void withdraw()
        {

        }
    }
}
