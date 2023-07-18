using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    public class Patient
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private string Sex { get; set; }
        public List<string> MedicalHistory { get; set; } = new List<string>();

        public Patient(string name, int age, string sex) { 
            
            Name = name;
            Age = age;
            Sex = sex;
        }

        public void AddProblem(string problem)
        {
            MedicalHistory.Add(problem);
        }
        public void DisplayMedicalHistory()
        {
            foreach(var problem  in MedicalHistory)
            {
                Console.WriteLine(problem); 
            }
            
        }

    }
}
