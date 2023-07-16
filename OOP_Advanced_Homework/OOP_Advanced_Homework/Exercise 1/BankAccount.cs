using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_1
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        private decimal Balance { get; set; }
        private List<Transaction> Transactions { get; set; }

        public BankAccount(int AccountNumber, string AccountHolder, decimal Blance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolder = AccountHolder;
            this.Balance = Blance;
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Transactions = new List<Transaction>() {
                new Transaction() {

                    Type = "Deposited",
                    Amount = amount
                }
            };
        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
            Transactions.Add(

                new Transaction()
                {
                    Type = "Withdrew",
                    Amount = amount
                }
             );
        }
        public decimal GetBalance()
        {
            return Balance;
        }
        public List<Transaction> GetTransactionHistory()
        {
            return Transactions;
        }
    }
}
