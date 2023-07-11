//
using OOP_Advanced_Course;

//Author author = new Author("Eminescu","em@yahoo.com", "Romania");
//author.Print();
BankAccount myAccount = new BankAccount(123456, "John Doe", 1000);

myAccount.Deposit(500);
myAccount.Withdraw(200);

Console.WriteLine(myAccount.GetBalance()); // Outputs 1300

List<string> transactions = myAccount.GetTransactionHistory();
foreach (string transaction in transactions)
{
    Console.WriteLine(transaction);
}

/* Outputs:
Deposited $500
Withdrew $200
*/