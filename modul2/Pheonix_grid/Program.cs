using System;
namespace Pheonix_grid
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "ReadMe")
            {
                if (ValidCheck(input) && PalindromeCheck(input)) Console.WriteLine("YES");
                else Console.WriteLine("NO");
                input = Console.ReadLine();
            }
        }   
        static bool PalindromeCheck(string input)
        {
            for (int i = 0; i < input.Length; i++)
                if (input[i] != input[input.Length - i - 1]) return false;
            return true;
        }
        static bool ValidCheck(string input)
        {
            if (input.Length < 3 && (input.Length - 3) % 4 != 0) return false;
            for (int i = 3; i < input.Length; i+=4)
                if (input[i] != '.') return false;
            if (input.Contains(' ') || input.Contains('\t') || input.Contains('_')) return false;
            return true;
        }
    }
}
// evala na ptichev
