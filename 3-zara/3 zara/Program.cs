using System;

namespace _3_zara
{
    internal class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int n1 = rnd.Next(0, 6);
            int n2 = rnd.Next(0, 6);
            int n3 = rnd.Next(0, 6);
            string red1 = "╔═══════╗";
            string[] red2 = { "║       ║", "║ o     ║", "║ o     ║", "║ o   o ║", "║ o   o ║", "║ o   o ║" };
            string[] red3 = { "║   o   ║", "║       ║", "║   o   ║", "║       ║", "║   o   ║", "║ o   o ║" };
            string[] red4 = { "║       ║", "║     o ║", "║     o ║", "║ o   o ║", "║ o   o ║", "║ o   o ║" };
            string red5 = "╚═══════╝";
            Console.Write(red1); Console.Write(red1); Console.Write(red1); Console.WriteLine();
            Console.Write(red2[n1]); Console.Write(red2[n2]); Console.Write(red2[n3]);
            Console.WriteLine();
            Console.Write(red3[n1]); Console.Write(red3[n2]); Console.Write(red3[n3]);
            Console.WriteLine();
            Console.Write(red4[n1]); Console.Write(red4[n2]); Console.Write(red4[n3]);
            Console.WriteLine();
            Console.Write(red5); Console.Write(red5); Console.Write(red5); Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Номерата са: {n1 + 1}, {n2 + 1}, {n3 + 1}");
        }
    }
}
