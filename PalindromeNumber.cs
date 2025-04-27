using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PalindromeNumber
    {
        //public static void Main(string[] args)
        //{
        //    PalindromeMethod(121);
        //}

        public static void PalindromeMethod(int num)
        {
            int originalNum = num;
            int reversedNum = 0;

            while (num > 0)
            {
                //121 -> Remainder -> 1
                int digit = num % 10;
                // 0*10 / 1 = 1
                reversedNum = (reversedNum * 10) + digit;
                //121/10 = 12
                num = num / 10;
            }

            //return originalNum == reversedNum;
            if (originalNum == reversedNum)
            {
                Console.WriteLine($"{originalNum} is a palindrome number.");
            }
            else
            {
                Console.WriteLine($"{originalNum} is not a palindrome number.");
            }
        }
    }
}