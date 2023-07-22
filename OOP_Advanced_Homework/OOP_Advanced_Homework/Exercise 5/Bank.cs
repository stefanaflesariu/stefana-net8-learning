using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_5
{
    public static class Bank 
    {
        public static double InterestRate { get; set; } = 0.01;
        public static int NumAccounts { get; set; }

        public static double CalculateInterest(double balance)
        {
            double interest;
            return interest = balance * InterestRate;
        }
        public static int GetNumAccounts() {
            
            return NumAccounts;
            
        }

    }
}
