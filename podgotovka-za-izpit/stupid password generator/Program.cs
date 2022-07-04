using System;
namespace stupid_password_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int c1 = 1; c1 <= n - 1; c1++)
                for (int c2 = 1; c2 <= n - 1; c2++)
                    for (int c3 = 0; c3 < l; c3++)
                        for (int c4 = 0; c4 < l; c4++)
                            for (int c5 = Math.Max(c1,c2) + 1; c5 <= n; c5++)
                                Console.Write($"{c1}{c2}{(char)('a'+c3)}{(char)('a' + c4)}{c5} ");
        }
    }
}
