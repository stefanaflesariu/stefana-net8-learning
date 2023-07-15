using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Advanced_Homework.Exercise_5
{
    public class BankAccount 
    {
        private string accountNumber; 
        private string accountHolder;
        private double balance;
        public string AccountNumber {

            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public string AccountHolder {

            get { return accountHolder; }
            set { accountHolder = value; }
        }
        public double Balance {

            get { return balance; }   
            set { balance = value; }
        }

        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
            Bank.NumAccounts++;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (Balance > amount)
            {
                Balance -= amount;
            }
            
        }
        public double GetInterest()
        {
           return Bank.CalculateInterest(Balance);
        }
    }
}
