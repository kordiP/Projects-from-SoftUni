using System;

namespace NumCounter
{
    class Program
    {
        static int n = 0, num1 = 1, num2 = 9;
        static void Bin()
        {
            int iB = 1;
            for (int d1 = 0; d1 <= num1; d1++)
                for (int d2 = 0; d2 <= num1; d2++)
                    for (int d3 = 0; d3 <= num1; d3++)
                        for (int d4 = 0; d4 <= num1; d4++)
                            for (int d5 = 0; d5 <= num1; d5++)
                                for (int d6 = 0; d6 <= num1; d6++)
                                    for (int d7 = 0; d7 <= num1; d7++)
                                        for (int d8 = 0; d8 <= num1; d8++)
                                        {
                                            if (iB < n) iB++;
                                            else if (iB == n)
                                            {
                                                Console.Write($"\n\n\n\t{d1}{d2}{d3}{d4} {d5}{d6}{d7}{d8}");
                                                iB++;
                                            }
                                            else return;
                                        }
        }
        static void Dec()
        {
            int iD = 1;
            for (int d100 = 0; d100 <= num2; d100++)
                for (int d10 = 0; d10 <= num2; d10++)
                    for (int d1 = 0; d1 <= num2; d1++)
                    {
                        if (iD < n) iD++;
                        else if (iD == n)
                        {
                            Console.WriteLine($"\t\t\t{d100}{d10}{d1}");
                            iD++;
                        }
                        else return;
                    }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.CursorVisible = false;
            while (true)
            {
                var b = Console.ReadKey(true);
                if (b.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();//Екрана се почиства тук, за да може при натискане на друг клавиш на екрана да няма промяна
                    n++;
                    Bin();
                    Dec();
                    if (n == 257)//Предотварява грешка: при n = 256 и натисната DownArrow дава грешка, защото n = 0
                    {
                        Console.Clear();
                        n = 0;
                        n++;
                        Bin();
                        Dec();
                    }
                }
                else if (b.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    n--;
                    Bin();
                    Dec();
                    if (n <= 0)
                    {
                        Console.Clear();
                        n = 255;
                        n++;
                        Bin();
                        Dec();
                    }
                }
                else if (b.Key == ConsoleKey.Escape) return;
            }
        }
    }
}