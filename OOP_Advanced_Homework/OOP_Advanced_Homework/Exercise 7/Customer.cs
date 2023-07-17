using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_7
{
    public class Customer : IContact
    {
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string Address
        {
            get { return Address; }
            set { Address = value; }
        }
        public int PhoneNumber
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }
    }
}
