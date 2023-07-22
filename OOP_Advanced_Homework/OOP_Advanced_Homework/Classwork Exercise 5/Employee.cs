using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Classwork_Exercise_5
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

        public string GetFullName()
        {
            return FirstName + LastName;
        }
        public double GetMonthlySalary()
        {
            return Salary = Salary / 12;
        }
    }
}
