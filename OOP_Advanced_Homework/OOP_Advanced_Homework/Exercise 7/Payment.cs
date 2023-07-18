using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_7
{
    public  class Payment : Reservation 
    {
        protected string PaymentType { get;set; }
        protected bool IsPaid;
        protected double Amount { get; set; }
        
    }
}
