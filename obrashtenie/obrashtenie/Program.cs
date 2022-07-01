using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrashtenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Gender?");
            string gender = Console.ReadLine();
            if (age >= 16)
            {
                if (gender == "f")
                {
                    Console.WriteLine("Ms");
                }
                else if (gender == "m")
                {
                    Console.WriteLine("Mr");
                }

            }
            else if (age < 16)
                if (gender == "m")
                {
                    Console.WriteLine("Master");
                }
                else if (age < 16)
                    if (gender == "f")
                    {
                        Console.WriteLine("Miss");
                    }
                    else Console.WriteLine("Nepravilno vavedeni danni!");
            
        }
    }
}
