using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Course.OOP_Advanced_2
{
    public class Rectangle : Shape
    {
        private int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int Width, int Height) {
            this.Width = Width;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }
        public override double GetPerimeter()
        {
            return 2 * Width + 2 * Height;
        }
    }
}
