using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Advanced_Course.OOP_Advanced_2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        private string gender;
        public string Gender
        {
            get { return gender; }   
            set {
                if(value.ToLower() == "Male"|| value.ToLower() == "Female")
                {
                    gender = value;
                }
                else
                {
                    throw new Exception("Gender is not correct");
                }
            }  
        }
        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, my name is {FirstName} {LastName} and I am a {Age} year old {gender}.");
         
        }
    }
}
