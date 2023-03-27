using System;

namespace nizove
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int x = s1.Length;
            int y = s2.Length;
            Console.WriteLine(x);
            Console.WriteLine(y);
            string s11;
            s11 = s1.Substring(2, 4);
            Console.WriteLine(s11);
          
            

        }
    }
}
