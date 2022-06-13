using System;

namespace bingoooooiooo
{
    class Program
    {
        public static void Print(string red1, string[] red2, string[] red3, string[] red4, string red5, int n1, int n2, int n3)
        {
            Console.Write(red1); Console.Write(red1); Console.Write(red1); Console.WriteLine();
            Console.Write(red2[n1]); Console.Write(red2[n2]); Console.Write(red2[n3]);
            Console.WriteLine();
            Console.Write(red3[n1]); Console.Write(red3[n2]); Console.Write(red3[n3]);
            Console.WriteLine();
            Console.Write(red4[n1]); Console.Write(red4[n2]); Console.Write(red4[n3]);
            Console.WriteLine();
            Console.Write(red5); Console.Write(red5); Console.Write(red5); Console.WriteLine();
            Console.WriteLine();
        }
        static void Main()
        {
            Random rnd = new Random();
            int n1 = rnd.Next(0, 6);
            int n2 = rnd.Next(0, 6);
            int n3 = rnd.Next(0, 6);
            string red1 = "╔═══════╗";
            string[] red2 = { "║       ║", "║ ♥     ║", "║ ♥     ║", "║ ♥   ♥ ║", "║ ♥   ♥ ║", "║ ♥   ♥ ║" };
            string[] red3 = { "║   ♥   ║", "║       ║", "║   ♥   ║", "║       ║", "║   ♥   ║", "║ ♥   ♥ ║" };
            string[] red4 = { "║       ║", "║     ♥ ║", "║     ♥ ║", "║ ♥   ♥ ║", "║ ♥   ♥ ║", "║ ♥   ♥ ║" };
            string red5 = "╚═══════╝";
            bool check = false;
            int cnt = 1;
            while (!check)
            {
                Print(red1, red2, red3, red4, red5, n1, n2, n3);
                Console.WriteLine($"Номерата са: {n1 + 1}, {n2 + 1}, {n3 + 1}");
                if (n1 == n2 && n2 == n3)
                {
                    Console.WriteLine("Бинго!");
                    Console.WriteLine($"Паднаха се 3 ендакви числа - {n1 + 1} след {cnt} завъртания!");
                    check = true;
                }
                cnt++;
                n1 = rnd.Next(0, 6);
                n2 = rnd.Next(0, 6);
                n3 = rnd.Next(0, 6);
            }
        }
    }
}
