using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_4
{
    public class Manager : Employee
    {
        public Department department { get; set; }
        public Manager(string Name, int Age, double Salary, Department department ){ 
           
            this.Name = Name;
            this.Age = Age;
            this.Salary = Salary;
            this.department = department;
        }
        public override double CalculateBonus()
        {
            return  Salary * 0.1;
        }
        public override string GetContactInfo()
        {
            return $"Name {this.Name} Age {this.Age}  Departament {this.department},Email: Phone: ";
        }
    }
}
