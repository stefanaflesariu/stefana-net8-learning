using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_7
{
    public class Customer : IContact, IHotel
    {
        public string HotelName  // implements the HotelName property on the IHotel interface.
        {
            get => HotelName;
            set => HotelName = value;
        }
        public string HotelAddress  // implements the HotelAddress property on the IHotel interface.
        {
            get => HotelAddress;
            set => HotelAddress = value;
        }
    }
}
