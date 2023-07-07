using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
{
    public class Address 
    {
        //Fields
        public string street;
        public string city;
        public string country;
        public int zipCode;

        //Constructor
        public Address(string street, string city, string country, int zipCode) {
            this.street = street;
            this.city = city;
            this.country = country;
            this.zipCode = zipCode;
        }
        public void getStreet() {

            Console.WriteLine($"Strada {this.street}");
        }
    }
}
