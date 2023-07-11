using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Week5
{
    //Ex3
    //Create a class Student with the following fields:
    //- name
    //-age
    //- scores(a list of integers representing the scores obtained by the student)

    //Add the following methods:
    //- GetAverageScore() - returns the average score of the student.
    //- GetMaxScore() - returns the maximum score obtained by the student.
    //- AddScore(score) - adds a new score to the student's list of scores.
    // - GetInfo() - returns a string with the student's name, age, and average score in the following format: "Name: [name], Age: [age], Average Score: [average score]".
    public class Student
    {
        public string name;
        public int age;
        public List<int> scores = new List<int>() { 5,8,9,6};
       

        public double GetAverageScore()
        {
            //return scores.Average();
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            return sum/scores.Count;
        }
        public int GetMaxScore()
        {
           // return scores.Max();
            int max = 0;
            foreach(int score in scores)
            {
                if (score > max)
                {
                    max= score;
                }
            }
            return max;
        }
        public void AddScore(int newScore)
        {
           // return scores.Add(newScore);
            scores.Add(newScore);
        }
        public string GetInfo()
        {
            return $"Name: {this.name} Age: {this.age} Avrage scores; {this.GetAverageScore}";
        }

    }
}

