using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Recursion
{
    class Program
    {
        static void printNumbers(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(" n = {0} ", n);
                printNumbers(n - 1);
            }
            Console.WriteLine("\n Recursion Unfolding --- n = {0} ", n);
        }
        static string getNumberString(int n)
        {        
            if (n == 0)
                return "";
            else
            {
                Console.WriteLine(n);
                return getNumberString(n-1);         
            }           
        }
        static void range(int start, int stop)
        /* Displays numbers between start and stop - start <= stop */
        {
           if (start > stop)
            {
                Console.WriteLine(" range = {0} ", stop);
                range(stop + 1, start);
            }
           else if (start == stop)
            {
                Console.WriteLine(" range = {0} ", stop);
            }
            else
            {
                Console.WriteLine(" range = {0} ", start);
                range(start + 1, stop);
            }
        }
        static int multiply(int x, int y)
        {
            if (y == 1)
            {
                return x;
            }          
            else
            {
                return x + multiply(x, dec(y));
            }         
        }
        static int power(int x, int y)
        {
            if (y == 0)
            {
                return 1;
            }
            else if (y == 1)
            {
                return x;
            }
            else
            {
                return multiply(x , power(x,dec(y)));
            }               
        }
        static int inc(int x)
        {
            return x + 1;
        }
        static int dec(int x)
        {
            return x - 1;
        }

        static void Main(string[] args)
        {
            // printNumbers(5);
            // range(2,10);
            // Console.Write(getNumberString(10));
            // Console.WriteLine(multiply(2, 200));
            Console.WriteLine(power(5, 4));
            // Console.WriteLine(dec(dec(10)));
            Console.ReadLine();
        }
    }
}
