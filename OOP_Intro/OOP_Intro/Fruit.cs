using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
{
        public class Fruit
        {
            public string name;
            public string color;
            public double price;
            public int nrOfPices;
            List<string> fruits = new List<string>();

            public Fruit(string name, string color, double price, int nrOfPiceses){
        
                this.name = name;
                this.color = color;
                this.price = price;
                this.nrOfPices = nrOfPiceses;
             }
             public void Print() {

                Console.WriteLine($" Fruit name: {this.name}, Price: {this.price}, Number of Pices: {this.nrOfPices}");
             }
             public double TotalPrice()
             {
                 double result = this.price * this.nrOfPices;
                 Console.Write("Total price: ");
                 return result;
             }

        }
}
