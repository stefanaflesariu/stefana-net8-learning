using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
{
    public class Book
    {
        public string name;
        public string author;
        public string title;
        public string description;

        public Book(string name, string author, string title, string description) {
            this.name = name;
            this.author = author;
            this.title = title;
            this.description = description;
        }
    }
}
