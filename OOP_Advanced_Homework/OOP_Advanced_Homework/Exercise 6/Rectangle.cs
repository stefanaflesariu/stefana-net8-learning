using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_6
{
    public class Rectangle :IColor,IShape
    {
        private double Width { get; set; }
        private double Height { get; set; }
        public string color;
        public string Color  // implements the Color property on the IColor interface.
        {
            get => color;
            set => color = value;
        }
        public Rectangle(double width, double height) {
            
            this.Width = width;
            this.Height = height;
            string color = "Black";
        }
        public Rectangle(double width, double height, string color) { 
            
            this.Width = width;
            this.Height = height;
            this.Color = color;
        }
        public double CalculateArea()
        {
            return Width * Height; 
        }
        public string CalculateArea(string unit)
        {
            return $"Area: {Width * Height} {unit} ";
        }

    }
}
