using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_7
{
    public  class Payment : Reservation 
    {
        public string PaymentType { get;set; }
        public bool IsPaid;
        public double Amount { get; set; }
        public void Pay(string PaymentType,double Amount) {
            
            if(Amount == stayPrice)
            {
                IsPaid = true;
            }
            else
            {
                throw new Exception("Payment not accepted");
                IsPaid=false;
            }
        }
    }
}
