using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Classwork_Exercise_5
{
    public class Manager : Employee
    {
        List<Employee> Employee { get; set; } = new List<Employee>();

        public Manager(string firstName, string lastName, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            Employee.Add(this);

        }
        public void AddEmployee(Employee employee)
        {
            Employee.Add(employee);
        }
        public double GetTotalMonthlySalary()
        {
            double totalSalary =0;
            foreach (Employee emp in Employee)
            {
                totalSalary += emp.Salary;
            }
            return totalSalary;
        }



    }
}
