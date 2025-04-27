using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FactorialClass
    {
        //public static void Main(string[] args)
        //{
        //    Factorial(4);
        //}

        public static void Factorial(int n)
        {
            int factorial = 1;

            for(int i=1; i<=n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"Factorial of number is:- {factorial}");
        }
    }
}
