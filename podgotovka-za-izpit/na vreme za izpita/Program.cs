using System;
namespace na_vreme_za_izpita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete chas_izpit");
            int chas_izpit = int.Parse(Console.ReadLine());
            Console.WriteLine("vuvedete minuta_izpit");
            int minuta_izpit = int.Parse(Console.ReadLine());
            Console.WriteLine("vuvedete chas_pristigan");
            int chas_pristigane = int.Parse(Console.ReadLine());
            Console.WriteLine("vuvedete minuta_pristigane");
            int minuta_pristigane = int.Parse(Console.ReadLine());
            int difference_number_hour;
            int difference_number_min;
            if (chas_izpit >= 0 && chas_izpit <= 23 && minuta_izpit >= 0 && minuta_izpit <= 59 && chas_pristigane >= 0 && chas_pristigane <= 23 && minuta_pristigane >= 0 && minuta_pristigane <= 59)
            {
                if (chas_izpit == chas_pristigane && minuta_izpit == minuta_pristigane)
                {
                    Console.WriteLine("On time");
                }
                if (chas_pristigane > chas_izpit && minuta_pristigane == minuta_izpit)
                {
                    difference_number_hour = chas_pristigane - chas_izpit;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{difference_number_hour}:00 hours late.");
                }
                else if (chas_izpit > chas_pristigane && minuta_pristigane == minuta_izpit)
                {
                    difference_number_hour = (-1) * (chas_pristigane - chas_izpit);
                    Console.WriteLine("Early");
                    Console.WriteLine($"{difference_number_hour}:00 hours early.");

                }
                else if (chas_pristigane == chas_izpit && minuta_pristigane < minuta_izpit)
                {
                    difference_number_min = minuta_izpit - minuta_pristigane;
                    if (difference_number_min > 30)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine(difference_number_min + " minutes early.");

                    }
                    if (difference_number_min <= 30)
                    {
                        Console.WriteLine("On time");
                        Console.WriteLine(difference_number_min + " minutes early.");

                    }
                }
                else if (chas_pristigane == chas_izpit && minuta_pristigane > minuta_izpit)
                {
                    difference_number_min = (minuta_izpit - minuta_pristigane) * (-1);
                    Console.WriteLine("Late");
                    Console.WriteLine(difference_number_min + " minutes late.");
                }
                else if (chas_izpit != chas_pristigane && minuta_pristigane != minuta_izpit)
                {
                    if (chas_pristigane > chas_izpit)
                    {
                        int minuti = 60 * (chas_pristigane - chas_izpit) + (minuta_pristigane - minuta_izpit);
                        Console.WriteLine("Late");
                        if (minuti < 60)
                        {
                            Console.WriteLine($"{minuti} minutes late");
                        }
                        else
                        {
                            int minuti2 = minuti % 60;
                            int hour = minuti / 60;
                            Console.WriteLine($"{hour}:{minuti2} hours late");
                        }
                    }
                    else
                    {
                        int minuti = 60 * (chas_izpit - chas_pristigane) + (minuta_pristigane - minuta_izpit);
                        Console.WriteLine("Early");
                        if (minuti < 60)
                        {
                            Console.WriteLine($"{minuti} minutes early");
                        }
                        else
                        {
                            int minuti2 = minuti % 60;
                            int hour = minuti / 60;
                            Console.WriteLine($"{hour}:{minuti2} hours early");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ne moje da ima takuv chas!");
                }
            }
        }
    }
}
