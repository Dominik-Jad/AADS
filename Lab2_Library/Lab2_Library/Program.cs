using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[5];  //declare an array of Book
            books[0] = new Book("Moby Dick");
            books[0].Author = new Person("Herman Melville", 20);
            books[1] = new Horror("The Creeping");
            books[2] = new Book("Hunger Games");
            books[2].Author = new Person("Suzanne Collins",50);
            books[3] = new Fantasy("Lord of the Rings");
            books[4] = new Romance("Love story");
            for (int i = 0; i < 5; i++)
                Console.WriteLine("{0}  {1}  {2}", "Author: "+books[i].Author.Name, "Title: "+books[i].Title, "Age: "+books[i].Author.Age);
            Console.ReadKey();

        }

    }
}