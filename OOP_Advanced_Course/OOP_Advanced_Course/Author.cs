using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Course
{
    public class Author
    {
        private string country;
        public string Name { get; set; } // cu litera mare
        public string Email { get; set; }
        public string Country {
        
            get { return country; }
            set { country = value; }
        }
        public Author(string name,string email,string country) { 
            Name = name;
            Country = country;
            Email=email;
        }
        public void Print()
        {
            Console.WriteLine($"Name:{Name}  Email:{Email}  Country:{Country}");
        }
    }
}
