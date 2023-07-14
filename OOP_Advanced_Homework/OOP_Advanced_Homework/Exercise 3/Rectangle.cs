using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_3
{
    public class Rectangle : Shape 
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(string Color,int Width, int Height) { 

            this.Color = Color;
            this.Width = Width;
            this.Height = Height;
        }
        public override double CalculateArea()
        {
            return Area = Width * Height;
        }
        public override double GetPerimeter()
        {
            return 2 * (Width + Height); 
        }

    }
}
