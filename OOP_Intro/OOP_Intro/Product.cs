using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
{
    public class Product
    {
        public string name;
        public int code;
        public double price;
        public string category;
        public Product(string name, int code, double price, string category) {
        
            this.name = name;
            this.code = code;
            this.price = price;
            this.category = category;
        }
    }
}
