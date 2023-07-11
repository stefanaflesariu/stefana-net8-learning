using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
{
    public class Crop
    {
        public string name;
        public string currentStage = "Seed";
        public List<string> stages= new List<string> {"Seed", "Sprout", "Plant","CanBeHarvested", "Harvested" };

        int i = 0;
        public string Water()
        {
            currentStage = stages[i];
            i++;
            return currentStage;
        }

        bool harvest = false;
        public void Harvest()
        {
            if(currentStage == "CanBeHarvested")
            {
                harvest = true;
                currentStage = "Harvested";
                Console.WriteLine("I harvested the crop");
            }
            else
            {
                harvest = false;
                Console.WriteLine("We can't harvest because current stage is not CanBeHarvested");
            }
            Console.WriteLine($"Current stage is: {this.currentStage}");
        }
    }
}
