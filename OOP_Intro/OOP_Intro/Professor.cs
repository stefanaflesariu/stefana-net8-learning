using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Intro.Ex8;
namespace OOP_Intro
{
    public class Professor
    {
        public string name;
        public string faculity;
        public string specialization;
        public List<Student> studentsWhoGiveTheirDegree = new List<Student>();

        public Professor(string name, string faculity, string specialization)
        {
            this.name = name;
            this.faculity = faculity;
            this.specialization = specialization;
        }
        public Professor(string name, string faculity, string specialization, List<Student> studentsWhoGiveTheirDegree)
        {
            this.name = name;
            this.faculity = faculity;
            this.specialization = specialization;
            this.studentsWhoGiveTheirDegree = studentsWhoGiveTheirDegree;
        }
    }
}
