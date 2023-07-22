using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_Homework.Exercise_2
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        private int PageCount { get; set; }
        private int CurrentPage { get; set; } = 1;

        public Book(string Title, string Author, int PageCount) {
            
            this.Title = Title;
            this.Author = Author;
            this.PageCount = PageCount;
        }
        public string GetTitle()
        {
            return Title;
        }
        public string GetAuthor()
        {
            return Author;
        }
        public int GetPageCount() {
        
            return PageCount;
        }
        public int GetCurrentPage()
        {
            return CurrentPage;
        }
        public void NextPage()
        {
            CurrentPage++;
        }
        public void PreviousPage()
        {
            CurrentPage--;
        }
    }
}
