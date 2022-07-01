using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generirane_na_kodove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i1 = 0; i1 < 10; i1++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    for (int i3 = 0; i3 < 10; i3++)
                    {
                        for (int i4 = 'a'; i4 <= 'z'; i4++)
                        {
                            for (int i5 = 'a'; i5 <= 'z'; i5++)
                            {
                                for (int i6 = 0; i6 < 10; i6++)
                                {
                                    if (i1 + i2 + i3 + i4 + i5 + i6 == m) 
                                    {
                                        if (n!=0)
                                        {
                                            Console.Write($"{i1}{i2}{i3}{(char)i4}{(char)i5}{i6} ");
                                            n--;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
