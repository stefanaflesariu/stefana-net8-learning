using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_3
{
    public class Circle : Shape
    {
        private double Radius {  get; set; }
        public double Pi = 3.14;
        public Circle(string Color, double Radius) { 
        
            this.Color = Color;
            this.Radius = Radius;
        }
        public override double GetPerimeter()
        {
            return 2 * Pi * Radius;
        } 
        public override double CalculateArea()
        {
            return Area = Pi * Math.Pow(Radius,2);
        }

    }
}
