using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
{
    public class Person
    {
        //Fields
        public string name;
        public int age;
        public int phoneNumber;
        public string emailAddress;
        public string city;

        //Constructor
        public Person(string name, int phoneNumber, int age) {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.age = age;
        }

        //METODE
        public void showContactDetails()
        {
            Console.WriteLine($"Contact details:  {this.name}, {this.phoneNumber}" );
        }
        public int showYearOfBirth()
        {
            int yearOfBirth = 2023-this.age;
            Console.Write($"{this.name}'s year of birth is: ");
            return yearOfBirth;
        }
     }
}
