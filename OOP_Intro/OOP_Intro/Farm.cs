using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
{
    public class Farm
    {
        public string name;
        public double area;
        public int animalCount;
        public Farm(string name, double area) { 
            this.name = name;
            this.area = area;
        }

        public void AddAnimals(int count)
        {
            animalCount = count;
            Console.WriteLine($"Ferma are {animalCount} animale");
        }
        public double CalculateDensity()
        {
            double density = animalCount / area;
            Console.Write("Density is: ");
            return density;
        }

    }
}
