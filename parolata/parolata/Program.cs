using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parolata
{
    class Program
    {
        static void Main(string[] args)
        {
            string parola="parola";
            const int MaxLength = 10;
            const int MinLength = 10;
            if (parola.Length > MaxLength)
            {
                Console.Write("");
            }
            else if (parola.Length < MinLength)
            {
                Console.Write("");
            }
            // Read the file and display it line by line.  
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Nasko\Desktop\english-words-master\words.txt");
            Console.WriteLine(lines);


        }
    }
}
