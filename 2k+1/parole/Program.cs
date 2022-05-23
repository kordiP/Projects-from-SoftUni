using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parole
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "";
            while (password.Length<=6)
            {
                Console.WriteLine("Въведи парола (повече от 8 знака)");
                password = Console.ReadLine(); 
            }
            Console.WriteLine("Паролата е записана.");
        }
    }
}
