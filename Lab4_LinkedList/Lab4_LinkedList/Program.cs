using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList testList = new LinkList();
            testList.AddItem(20);
            testList.AddItem(44);
            testList.AddItem(32);
            testList.AddItem(1);
            testList.AddItem(44);
            testList.AddItem(54);
            testList.AddItem(44);

            testList.DisplayItems();

            System.Console.WriteLine("Number of Items: "+testList.NumberOfItems());

            System.Console.WriteLine("Is 50 present?: "+testList.IsPresentItem(50));

            testList.RemoveItem(44);

            testList.DisplayItems();

            System.Console.WriteLine("Number of Items: " + testList.NumberOfItems());
            Console.ReadKey();
        }


    }
}
