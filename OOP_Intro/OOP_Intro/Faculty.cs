using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
{
    public class Faculty
    {
        public string firstName;
        public string lastName;
        public int employeeId;
        public List<string> subjectsTaught = new List<string>();

        public Faculty(string firstName, string lasName, int employeeId, List<string> subjectsTaught) { 
            
            this.firstName = firstName;
            this.lastName = lasName;
            this.employeeId = employeeId;
            this.subjectsTaught = subjectsTaught;
        
        }

        public string GetFullName()
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }
        public List<string> GetSubjectsTaught()
        {
           this.subjectsTaught = subjectsTaught;
            return subjectsTaught;
        }
    }
}
