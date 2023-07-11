using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Course
{
    public class BankAccount
    {
        //Proprietati
        public int accountNumber;
        public  string accountHolder;
        public  double balance;
        List<string> transaction = new List<string>();
        public BankAccount( int accountNumber, string accountHolder,int balance) {
           
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }

        public void Deposit(int amount)
        {
            balance += amount;
            transaction.Add($"Deposited ${amount}");
        }
        public void Withdraw(int amount)
        {
            balance -= amount;
            transaction.Add($"Withdrew ${amount}");
        }
        public double GetBalance()
        {
            return balance;
        }
        public List<string> GetTransactionHistory()
        {
            return transaction;
        }
        
    }
}
