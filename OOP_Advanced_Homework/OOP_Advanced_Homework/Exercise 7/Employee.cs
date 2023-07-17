using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_7
{
    public class Employee : Payment,IContact
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
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
        private double Salary { get; set; }
        public Employee(string name, string address, int phoneNumber)
        {

            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }
        public void AddNewReservation(Reservation reservation)
        {
            if (IsPaid == true)
            {
                Reservations.Add(reservation);
            }
        }


    }
}
