using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_4
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public enum Department
        {
            HR,
            IT,
            Sales,
            Marketing,
        }
        public Employee() { }
        public abstract double CalculateBonus();
        public virtual string GetContactInfo()
        {
            return $"Name {this.Name} Age {this.Age} Salary {this.Salary}";
        }

    }
}
