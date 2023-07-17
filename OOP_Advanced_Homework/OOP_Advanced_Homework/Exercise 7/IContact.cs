using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_7
{
    public interface IContact
    {
        string Name { get; set; }    
        string Address { get; set; }
        int PhoneNumber { get; set; }
    }
}
