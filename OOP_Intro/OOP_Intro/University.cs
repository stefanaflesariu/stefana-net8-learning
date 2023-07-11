using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
{
    public class University
    {
        public string name;
        public List<Student> students =  new List<Student>();
        public List<Faculty> faculties = new List<Faculty>();

        public University(string name) { this.name = name; }

        public void AddStudent( Student student)
        {
            students.Add(student);
        }
        public void AddFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
        }
        public int GetStudentCount()
        {
            return students.Count;
        }
        public int GetFacultyCount()
        {
            return faculties.Count;
        }
    }
}
