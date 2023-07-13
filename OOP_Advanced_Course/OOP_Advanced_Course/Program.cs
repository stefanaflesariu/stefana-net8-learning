//
using OOP_Advanced_Course;
using OOP_Advanced_Course.OOP_Advanced_2;
using System.Xml.Linq;

//Author author = new Author("Eminescu","em@yahoo.com", "Romania");
//author.Print();
//BankAccount myAccount = new BankAccount(123456, "John Doe", 1000);

//myAccount.Deposit(500);
//myAccount.Withdraw(200);

//Console.WriteLine(myAccount.GetBalance()); // Outputs 1300

//List<string> transactions = myAccount.GetTransactionHistory();
//foreach (string transaction in transactions)
//{
//    Console.WriteLine(transaction);
//}

/* Outputs:
Deposited $500
Withdrew $200
*/

/*Person person = new Person();
person.FirstName = "Andrei";
person.LastName = "Popescu";
person.Age = 30;
//person.Gender = "Male";
person.Introduce();

Teacher teacher = new Teacher();
teacher.FirstName = "Alexandra";
teacher.LastName = "Dumitrescu";
teacher.Age = 35;
//teacher.Gender = "Famale";
teacher.Courses = new List<Course> {
    new Course() {Id=1,Name="Mate"},
    new Course  { Id = 2, Name = "Romana" } 
};
teacher.Introduce();
*/
Circle myCircle = new Circle(5);
Rectangle myRectangle = new Rectangle(5, 10);

Console.WriteLine(myCircle.GetArea()); // Outputs 78.5398163397448
Console.WriteLine(myCircle.GetPerimeter()); // Outputs 31.4159265358979

Console.WriteLine(myRectangle.GetArea()); // Outputs 50
Console.WriteLine(myRectangle.GetPerimeter()); // Outputs 30

Employee myEmployee = new Employee()
{
    FirstName = "Alex",
    LastName = "Popescu",
    Salary=12000.56
};
myEmployee.GetFullName();
myEmployee.GetMonthlySalary();