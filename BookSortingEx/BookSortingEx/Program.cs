
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSortingEx
{
    class Program
    {

        static void swap<T>(ref T x, ref T y)
        {

           //swapcount++;
            T temp = x;
            x = y;
            y = temp;
        }
        // Complete the code of the Selection Sort to sort an array of Book
        // To complete this code you need first to complete the CompareTo method in the class Book
        
       /* static void SelectionSort(Book[] library)
        {

            // for int:
            // if (a[j] < a[smallest])
            // smallest = j;

            // for Book
            // compare library[j] and library[smallest] using
            // CompareTo method
            for (int i = 0; i < library.Length - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < library.Length; j++)
                {
                    if (library[j].CompareTo(library[smallest]) < 0)
                        smallest = j;

                }
                swap(ref library[i], ref library[smallest]);
            }

        }
        */
        /*static void quickSortDD2(int[] items, int left, int right)
        {
            int i, j;
            i = left; j = right;
            int pivot = items[left];

            while (i <= j)
            {
                for (; (items[i] < pivot) && (i < right); i++) ;
                for (; (pivot < items[j]) && (j > left); j--) ;

                if (i <= j)
                    swap(ref items[i++], ref items[j--]);
            }

            if (left < j) quickSortDD2(items, left, j);
            if (i < right) quickSortDD2(items, i, right);
        }*/

        static void quickSortDD2gen<T>(T[] items, int left, int right) where T : IComparable<T> 
        {
            int i, j;
            i = left; j = right;
            T pivot = items[left];

            while (i <= j)
            {
                for (; (items[i].CompareTo(pivot) < 0) && (i.CompareTo(right) < 0); i++) ;
                for (; (pivot.CompareTo(items[j]) < 0) && (j.CompareTo(left) > 0); j--) ;

                if (i <= j)
                    swap(ref items[i++], ref items[j--]);

            }
            if (left < j) quickSortDD2gen(items, left, j);
            if (i < right) quickSortDD2gen(items, i, right);
        }


        static void Main(string[] args)
        {

            
            string[] array1 = { "Fred", "Zoe", "Angela", "Umbrella", "Ben" };
            string[] titles = {"Writing Solid Code",
                "Objects First","Programming Gems",
                "Head First Java","The C Programming Language",
                "Mythical Man Month","The Art of Programming",
                "Coding Complete","Design Patterns", 
                "ZZ"};
            string[] authors ={ "Maguire", "Kolling", "Bentley", "Sierra", "Richie", "Brooks", "Knuth", "McConnal", "Gamma", "Weiss" };
            string[] isbns = { "948343", "849328493", "38948932", "394834342", "983492389", "84928334", "4839455", "21331322", "348923948", "43893284", "9483294", "9823943" };


            Book[] library = new Book[10] ;
            for (int i = 0; i < library.Length; i++)
            {
                library[i] = new Book(isbns[i], titles[i], authors[i]);
                
            }
     
            int[] itemsI = { 5, 2, 1, 3, 4 };
            string[] itemsS = { "a", "h", "v", "c", "b" };

            quickSortDD2gen(itemsI, 0, itemsI.Length - 1);
            quickSortDD2gen(itemsS, 0, itemsS.Length - 1);
            quickSortDD2gen(library, 0, library.Length - 1);

            Console.WriteLine("Sorted:");

            foreach (int i in itemsI)
            {
                Console.WriteLine("{0} ", i);
            }

            foreach (string s in itemsS)
            {
                Console.WriteLine("{0} ", s);
            }

          foreach (Book b in library)
          {
              Console.WriteLine("{0} ", b);
          }

            Console.ReadKey();         
        }

    }
}
