using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_7
{
    public interface IContact
    {
        //custom properties
        public string Name { 
            
            get { return Name; }
            set { Name = value; }
        }
        public string Address {

            get { return Address; }
            set { Address = value; }
        }
        public string City {

            get { return City; }
            set { City = value; }
        }
        public int PhoneNumber {

            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }
    }
}
