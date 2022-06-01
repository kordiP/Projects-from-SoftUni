using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string rev1 = name.Substring(0, 1);       
            string rev2 = name.Substring(1, 1);
            string rev31 = name.Substring(2,1);
            Console.WriteLine(rev31 + rev2 + rev1);
            
           
             
        }
    }
}
