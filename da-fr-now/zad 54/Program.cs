using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i1 = 0; i1 <= 9; i1++)
            {
                for (int i2 = 0; i2 <= 9; i2++)
                {
                    for (int i3 = 0; i3 <= 9; i3++)
                    {
                        for (int i4 = 0; i4 <= 9; i4++)
                        {
                            if (i1 + i4 == n && i2 % 2 != 0 && i3 == 4 || i3 == 7 && i1 + i4 == n && i2 % 2 != 0) 
                            {
                                Console.Write($"{i1}{i2}{i3}{i4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
