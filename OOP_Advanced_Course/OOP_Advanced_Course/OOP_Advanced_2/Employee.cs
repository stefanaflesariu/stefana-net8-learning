using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Course.OOP_Advanced_2
{
    public  class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

        public void GetFullName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
        public double GetMonthlySalary()
        {
            return Salary / 12;
        }
    }
}
