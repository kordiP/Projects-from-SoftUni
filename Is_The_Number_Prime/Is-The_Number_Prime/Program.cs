using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_The_Number_Prime
{
    internal class Program
    {
        public static bool IsPrime(int d)
        {
            if (d <= 1) return false;
            if (d == 2) return true;
            if (d % 2 == 0) return false;
            int bound = (int)Math.Floor(Math.Sqrt(d));  // This part of the code checks whether the divisor is prime by finding the square root (w/ floor if not whole) of the number
            for (int i = 3; i <= bound; i += 2)        // and then using it to go in a loop, that checks numbers from 3 to the [square root of the number],
                if (d % i == 0)                       // skipping every second number <it's not prime because it is a divisor of 2> and it checks them by dividing by i.
                    return false;                    // It does exactly that, because there is no need for check if it is a divisor of 2 AND after that checks whether it can be divided by any number that is NOT a divisor of 2. 
            return true;
        }
        static void Main()
        {
            int d = int.Parse(Console.ReadLine());
            if (IsPrime(d)) Console.WriteLine("Yep, it is a prime number.");
            else Console.WriteLine("Nope, unfortunately this is not a prime number.");

        }
    }
}
