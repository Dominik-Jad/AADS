using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Generic_LinkList
{
    class LinkListGen<T> where T : IComparable
    {
        private LinkGen<T> list;
        public LinkListGen()
        {
            this.list = null;
        }
        public void AddItem(T item)
        {
            list = new LinkGen<T>(item, list);
        }
        public string DisplayItems() //write items to string and return
        {
            LinkGen<T> temp = list;
            string buffer = "";
            while (temp != null) // move one link and add head to the buffer
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
            return buffer;
        }
        public int NumberOfItems() // returns number of items in list
        {
            LinkGen<T> temp = list;
            int count = 0;
            while (temp != null) // move one link and add 1 to count
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }
        public bool IsPresentItem(int item)
        {
            // Description : searches list for item – returns true if found and false otherwise
            LinkGen<T> temp = list;

            while (temp != null)
            {
                if (temp.Data.Equals(item))
                {
                    return true;

                }
                temp = temp.Next;
            }
            return false;
        }
        public void RemoveItem(int item)
        {
            LinkGen<T> current = list;
            LinkGen<T> previous = null;
            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        current = current.Next;
                    }
                    else
                    {
                        previous = current;
                        current = current.Next;
                        list = current;
                    }
                }
                else
                    previous = current;
                    current = previous.Next;
            }
        }
        public void AppendItem(T item)
        {
            LinkGen<T> temp = list;
            if (list == null)
            {
                AddItem(item);
            }
            else
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new LinkGen<T>(item, null);
            }
        }
        public void Concat(LinkListGen<T> list2)
        {
            LinkGen<T> temp = list2.list;
            while (temp != null)
            {
                AppendItem(temp.Data);
                temp = temp.Next;
            }
        }
        public void Copy(LinkListGen<T> copyList)
        {
            LinkGen<T> temp = copyList.list;
            while (temp != null)
            {
                AppendItem(temp.Data);
                temp = temp.Next;
            }
        }
        public void Sort()
        {
            LinkGen<T> temp = list;
            while (temp.Next != null)
            {
                if (temp.Data.CompareTo(temp.Next.Data) == -1)
                {
                    T item = temp.Data;
                    temp.Data = temp.Next.Data;
                    temp.Next.Data = item;
                    temp = list;
                }
                else
                {
                    temp = temp.Next;
                }
            }
        }
        public void InsertInOrder(T item)
        {
            LinkGen<T> temp = list;
            if (temp == null)
            {
                list = new LinkGen<T>(item, list);
            }
            else
            {
                while (temp != null)
                {
                    if (temp.Data.CompareTo(item) < 0)
                    {
                        AddItem(item);
                        temp = null;
                    }
                    else if (temp.Next == null || temp.Next.Data.CompareTo(item) <= 0)
                    {
                        temp.Next = new LinkGen<T>(item, temp.Next);
                        temp = null;
                    }
                    else
                    {
                        temp = temp.Next;
                    }
                }
            }
        }
    }
}