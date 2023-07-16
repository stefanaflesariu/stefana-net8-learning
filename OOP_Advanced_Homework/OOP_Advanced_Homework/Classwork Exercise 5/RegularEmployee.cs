using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Classwork_Exercise_5
{
    public sealed class RegularEmployee :Employee
    {
        public RegularEmployee(string firstName, string lastName, double salary) {
            
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }
    }
}
