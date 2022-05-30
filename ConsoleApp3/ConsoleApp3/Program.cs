                                                                                                                                   using System;

namespace niz_upr

{
    class Program
    {
        static void Main(string[] args)
        {
            string s1= Console.ReadLine();
            string s2 = Console.ReadLine();
            int i = s1.IndexOf(s2);
            if (i < 0) Console.WriteLine("ne se sadurja");
            else Console.WriteLine("sadarja se");
            Console.WriteLine(s1.IndexOf(s2));
            Console.WriteLine(s1[0]);
            int x = s1.Length;
            Console.WriteLine(s1[x-1]);
        }
    }
}
