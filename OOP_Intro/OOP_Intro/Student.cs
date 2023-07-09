using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public int studentId;
        public double gpa;
        public bool hasHonors;
        
        public  Student(string firstName, string lastName, int studentId, double gpa) {
        
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentId = studentId;
            this.gpa = gpa;
        }
        public string GetFullName()
        {
            string fullName= firstName + " " + lastName;
            return fullName;
        }
        public void HasHonors()
        {
            if(gpa >=3.5)
            {
                hasHonors = true;
            }
            else
            {
                hasHonors= false;
            }
        }
    }
}
