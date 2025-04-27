using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PalindromeString
    {
        //public static void Main(string[] args)
        //{
        //    palindromeMethod("madamr");
        //}

        public static bool palindromeMethod(string plainText)
        {
            string str = plainText;
            string rev = "";

            for (int i = str.Length - 1; i >= 1; i--)
            {
                rev =  rev + str[i];
            }

            if (rev == str)
            {
                Console.WriteLine("Palindrome string");
            }
            else
            {
                Console.WriteLine("Not a palindrome string");
            }

            return rev == str ? true : false;
        }

    }
}

//Character m	a	d	a	m	r
//Index	0	1	2	3	4	5
//So,

//str.Length = 6

//Loop starts from i = 5 (because str.Length - 1 = 5)