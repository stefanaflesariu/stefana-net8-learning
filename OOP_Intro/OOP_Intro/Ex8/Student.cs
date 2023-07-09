using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro.Ex8
{
    public class Student
    {
        public string name;
        public DateTime startDate;
        public DateTime endDate;
        public string college;
        public DateTime birthDate;
        public bool isStillStudent;
        public DateTime dateTimeToday = DateTime.UtcNow;
        public Student(string name, DateTime startDate, string college, DateTime birthDate)
        { 
            this.name = name;
            this.startDate = startDate;
            this.college = college;
            this.birthDate = birthDate;
        }
        public void IsStillStudent( DateTime endDate) { 

            if (endDate == null) {

                Console.WriteLine("Is still student");
            }
            else
            {
                Console.WriteLine("Is no longer a student");
            }
        }
        public int GetAge()
        {
            int age = dateTimeToday.Year - birthDate.Year;
            return age;
        }
        public void  Print()
        {
            Console.WriteLine($" Name: {this.name}, Start date: {this.startDate}, End date: {this.endDate}, College: {this.college}, Birth date: {this.birthDate}");
        }
    }
}
