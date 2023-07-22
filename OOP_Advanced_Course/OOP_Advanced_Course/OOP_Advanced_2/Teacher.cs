using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Course.OOP_Advanced_2
{
    public class Teacher :Person
    {
        public List<Course> Courses {  get; set; }
        public override void Introduce()
        {
            
            Console.WriteLine($"Hi, my name is {FirstName} {LastName} and i'm a teacher.");
            foreach (Course course in Courses)
            {
                Console.WriteLine($"Id : {course.Id} Name : {course.Name}");
            }
        }
    }
}
