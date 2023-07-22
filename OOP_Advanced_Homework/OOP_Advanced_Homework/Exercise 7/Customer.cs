using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_7
{
    public class Customer : Payment, IContact
    {
        private string customerName;
        private string address;
        private int phoneNumber;
        public string Name
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public Customer(string name, string address, int phoneNumber)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }
        public string Pay(string PaymentType, double Amount)
        {

            if (Amount == stayPrice)
            {
                IsPaid = true;
                return "Payment accepted";
            }
            else
            {
                IsPaid = false;
                throw new Exception("Payment not accepted");
            }
        }
        public string PrintCustomerName()
        {
            return Name;
        }
    }
}
