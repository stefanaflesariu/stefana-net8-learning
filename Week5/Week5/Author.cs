using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week5

{    //Ex 4
    //Create a class Author with one constructor to initialize the values:
    //- name
    //- email
    //- country
    //Add Print Method(to show all details)
    public class Author
    {
        public string name;
        public string email;
        public string country;
        public Author(string name, string email, string country)
        {
            this.name = name;
            this.email = email;
            this.country = country; 
        }

        public void printMethod()
        {
            Console.WriteLine("Nume: "+ name+" Email: "+email, " Country: "+country);
        }
    }
}
