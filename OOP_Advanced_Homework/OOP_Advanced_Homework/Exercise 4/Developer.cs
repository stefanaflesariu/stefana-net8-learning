using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_4
{
    public class Developer : Employee
    {   
        private List<string> Skills { get; set; }
        private bool IsJunior { get; set; }
        public Developer(string name, int age, double salary,List<string> skills, bool isJunior)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Skills = skills;
            IsJunior = isJunior;
        }
        public override double CalculateBonus()
        {
            return Salary * 0.2;
        }
        public override string GetContactInfo()
        {
            return $"Name {this.Name} Age {this.Age}  Departament: ,Email: Phone: ";
        }
    }
}
