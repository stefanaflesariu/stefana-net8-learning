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
        private string employeeName;
        private string address;
        private int phoneNumber;
        public string Name
        {
            get { return employeeName; }
            set { employeeName = value; }
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
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
        private double Salary { get; set; }
        public Employee(string name, string address, int phoneNumber,double salary)
        {

            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Salary = salary;
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
