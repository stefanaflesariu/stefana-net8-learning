using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public string gender;
        
        public Person(string firstName, string lastName, int age, string gender) { 
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            if(Verifica(gender)==false)
            {
                throw new Exception("Gender is not corect");
            }
        }
        public  bool Verifica(string gender)
        {
            if(gender == "Male" || gender=="Female")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
