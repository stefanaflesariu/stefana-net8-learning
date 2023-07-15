using OOP_Advanced_Homework.Exercise_4;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Advanced_Homework.Exercise_6
{
    public class Circle : IColor , IShape
    {
        public double Pi = 3.14;
        public double Radius { get; set; }
        public string color;
        public string Color  // implements the Color property on the IColor interface.
        {
            get => color;
            set => color = value;
        }
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public Circle(double Radius, string Color)
        {
            this.Radius = Radius;
            this.Color = Color;
        }
        public double CalculateArea()
        {
            return Pi * Math.Pow(Radius, 2);
        }
        public string CalculateArea(string unit)
        {
             return $"Area: {Pi * Math.Pow(Radius,2)} {unit}";
        }
    }
}
