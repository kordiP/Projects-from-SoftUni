using System.Diagnostics.Tracing;

namespace test_Matura
{
    internal class Program
    {
        static void Main()
        {
            string w = "abba";
            for (int i = 0; i < 3; i++)
            {
                w.Substring(2);
                Console.WriteLine(w);
                w = w + w;
                Console.WriteLine(  w);
            }
            Console.WriteLine(w);
        }
        public static void Change(int n)
        {
            if (n > 0)
            {
                Change(n/2);
                Console.Write(n % 2);
            }
        }
    }
}