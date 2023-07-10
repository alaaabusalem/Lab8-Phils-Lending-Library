using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phil_Lending_Library.Classes
{
    public class Book
    {
        public string Title { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int NumOfPages { set; get; }

        //public bool IsBorrow { set; get; }

        public Book()
        {

        }
        public Book(string title, string firstName, string lastName, int numOfPages)
        {
            Title = title;
            FirstName = firstName;
            LastName = lastName;
            NumOfPages = numOfPages;
            
        }
    }
}
