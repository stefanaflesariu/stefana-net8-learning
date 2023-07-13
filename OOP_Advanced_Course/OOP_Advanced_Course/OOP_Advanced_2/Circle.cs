using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Course.OOP_Advanced_2
{
    public class Circle: Shape
    {
        public int Radius { get; set; }
        public double Pi { get; set; }

        public Circle( int Radius) { 
            this.Radius = Radius;
            this.Pi = 3.14;
        }
        public override double GetArea()
        {
            return Pi*Math.Sqrt(Radius);
        }
        public override double GetPerimeter()
        {
            return 2*Pi*Radius;
        }
    }
}
