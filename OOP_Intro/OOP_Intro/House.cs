using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
{
    public class House
    {
        public int number;
        public string street;
        public string color;
        public string numberOfWindow;


        public House(int number, string Street, string color)
        {
            this.number = number;
            this.street = Street;
            this.color = color;
        }

        public void Print()
        {
            Console.WriteLine($" House number: {this.number} Street: {this.street} Color: {this.color}");
        }
    }
}
