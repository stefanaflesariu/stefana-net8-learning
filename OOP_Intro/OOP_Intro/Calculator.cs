using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            int sum=x+y;
            return sum; 
        }
        public int Subtract(int x,int y)
        {
            int sub=x-y;
            return sub;
        }
        public int Multiply(int x,int y)
        {
            int mul = x * y;
            return mul;
        }
        public int Divide(int x,int y) { 

            int div = x / y;
            return div;
        }
        public double Power(double x,double y)
        {
            return Math.Pow(x, y);
        }
        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
