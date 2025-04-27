using System;
using System.Drawing;

public class HelloWorld
{
    //public static void Main(string[] args)
    //{
    //    PrimeNum(100);
    //}

    public static void PrimeNum(int n)
    {
        bool isPrime = true;
        
        if (n <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
                //isPrime = true;
            }
        }
             
        if(isPrime)
        {
            Console.WriteLine(n + " is a prime number.");
        }
        else
        {
            Console.WriteLine(n + " is not a prime number.");
        }

    }
}


//for (int i = 2; i <= Math.Sqrt(num); i++)

//→ Math.Sqrt(25) = 5, so the loop will run from i = 2 to 5.

//Let's check each step:

//i = 2: 25 % 2 = 1(remainder, not divisible) → continue

//i = 3: 25 % 3 = 1 → continue

//i = 4: 25 % 4 = 1 → continue

//i = 5: 25 % 5 = 0(perfectly divisible)

//Since 25 is divisible by 5, it’s not a prime number, so it returns false immediately.