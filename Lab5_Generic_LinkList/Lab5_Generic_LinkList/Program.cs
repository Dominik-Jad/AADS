using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Generic_LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            LinkListGen<int> testList = new LinkListGen<int>();
            LinkListGen<int> testList2 = new LinkListGen<int>();
            LinkListGen<int> testList3 = new LinkListGen<int>();
            LinkListGen<int> testList4 = new LinkListGen<int>();
            testList.AddItem(4);
            testList.AddItem(6);
            testList.AddItem(12);

            testList4.AddItem(1);
            testList4.AddItem(4);
            testList4.AddItem(3);
            testList4.AddItem(2);
            testList4.AddItem(17);
            testList4.AddItem(20);

            testList4.Sort();
            System.Console.WriteLine(testList4.DisplayItems());

            testList.DisplayItems();

            System.Console.WriteLine("Number of Items: " + testList.NumberOfItems());

            System.Console.WriteLine("Is 5 present?: " + testList.IsPresentItem(5));

            testList.RemoveItem(12);
            System.Console.WriteLine("Remove Item: " + testList.DisplayItems());
        
            System.Console.WriteLine("Number of Items: " + testList.NumberOfItems());

            testList.AppendItem(10);
            System.Console.WriteLine("Append Item: " +testList.DisplayItems());

            testList2.AddItem(19);
            testList2.AddItem(23);
            testList2.AddItem(29);

            testList.Concat(testList2);
            System.Console.WriteLine("Concat List: " + testList.DisplayItems());

            testList3.Copy(testList2);
            System.Console.WriteLine("Copy List: " + testList3.DisplayItems());

            testList.Sort();
            System.Console.WriteLine("Sort List: " + testList.DisplayItems());

            testList.InsertInOrder(15);
            System.Console.WriteLine("Insert In order " + testList.DisplayItems()); 

            Console.ReadKey();
        }
    }
}
