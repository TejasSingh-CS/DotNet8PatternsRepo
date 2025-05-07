using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Fibonacci
    {
        public static void Main(string[] args)
        {
            FibonacciMethod(10);
        }

        private static void FibonacciMethod(int v)
        {
            int first = 0;
            int second = 1;
            int next;

            //int n = 10;
            Console.WriteLine("Fibonacci Series: " + first + " " + second);
            for (int i = 2; i < v; i++)
            {
                next = first + second;
                first = second;
                second = next;

                Console.WriteLine(" " + next);

            }
        }
    }
}
