using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_7
{
    public class Reservation : Room
    {
        public DateTime ArriveDate { get; set; }
        public DateTime DepartureDate { get; set; }
        private int numberOfDay;
        public double stayPrice;
        public int NumberOfDay()
        {
           return  numberOfDay = DepartureDate.Day - ArriveDate.Day;
        }
        public override double StayPrice()
        {
            return stayPrice = PricePerNight * NumberOfDay();
        }
        public string PrintReservationDatails()
        {
            return $"The name of the guest  Room {RoomNumber} Type {RoomType} Number of days {NumberOfDay()} Departure Date {DepartureDate}  The price for the stay {StayPrice()}";
        }
    }
}
