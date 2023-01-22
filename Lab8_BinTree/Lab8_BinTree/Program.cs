using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_BinTree
{
    class Program
    {
        static void Main(string[] args)
        {
            string inO = "";
            string pre = "";
            string post = "";
            string delete = "";

            BinTree<int> mytree = new BinTree<int>(null);
            mytree.InsertItem(10);
            mytree.InsertItem(5);
            mytree.InsertItem(20);
            mytree.InsertItem(15);
            mytree.InsertItem(30);
           

            mytree.PreOrder(ref pre);
            Console.WriteLine(pre);
            Console.WriteLine(mytree.Height());
            Console.WriteLine(mytree.Count());
            Console.WriteLine(mytree.Contains(10));
           //mytree.PreOrder(ref pre);
           //Console.WriteLine(pre);
           //mytree.PostOrder(ref post);
           //Console.WriteLine(post);
            mytree.RemoveItem(15);
            mytree.PreOrder(ref delete);
            Console.WriteLine(delete);
            Console.ReadKey();
        }
    }
}
