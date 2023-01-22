using System;
using System.Collections.Generic;
using System.Text;

namespace BookSortingEx
{
    class Book : IComparable<Book>
    {

        public string ISBN;
        public string Title;
        public string Author;

        public Book(string ISBN, string Title, String Author) 
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
        }
        
        public override string ToString()
        {
            return Title + " by " + Author + " ISBN: " + ISBN;
        }

        
       // Complete the code of CompareTo to compare two objects of the class Book using their title 
        public int CompareTo(Book other)
        {
            // a method which return an int (+1/-1) 
            // if this instance is “bigger” than other  

            if (this.Title.CompareTo(other.Title) < 1)
            {
                return 1;
            }
            else
            {
                return -1;
            }
           
        }

 
    }


}
