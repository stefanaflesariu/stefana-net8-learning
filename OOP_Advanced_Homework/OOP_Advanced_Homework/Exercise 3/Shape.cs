using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_3
{
    public abstract class Shape
    {
        public string Color { get; set; }
        public double Area { get; set; } = 0;
        public abstract double CalculateArea();
        public abstract double GetPerimeter();
    }
}
