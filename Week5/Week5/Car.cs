using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    //Ex2
    //Create a class Car with one constructor and the following fields:
    //- model
    //- year
    //- color
    //- mileage
    public class Car
    {
        public string model;
        public int year;
        public string color;
        public int mileage;
        //Constructorc
        public Car(string model, int year, string color, int mileag) { 
        
            //ceea ce primim cand initializam obiectul se salveaza in field-ul nostru
            this.model = model;
            this.year = year;
            this.color = color;
            this.mileage = mileag;
        }
        //METODE
        public string GetModel()
        {
            return model;
        }
        public int GetYear()
        {
            return year;
        }
        public string GetColor()
        {
            return color;
        }
        public int GetMileage()
        {
            return mileage;
        }
        public void Drive()
        {
            this.mileage = mileage + 10;
        }
    }
}
