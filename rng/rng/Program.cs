class Program
{
    static void Main()
    {
        Console.Write("What is your minimum number? ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("What is your maximum number? ");
        int max = int.Parse(Console.ReadLine());
        Random rng = new Random();
        int number = rng.Next(min, (max + 1));
        Console.WriteLine("The generated number was: " + number);
        PrintInfo();
        ConsoleKey c;
        Console.CursorVisible = true;
        do
        {
            c = Console.ReadKey(true).Key;
            if (c == ConsoleKey.N)
            {
                int three = rng.Next(min, (max + 1));
                do
                {
                    three = rng.Next(min, (max + 1));
                } while (three % 3 != 0);
                Console.WriteLine("The next generated number was (divisor of three): " + three);
            }
            else if (c == ConsoleKey.S)
            {
                int even = rng.Next(min, (max + 1));
                do
                {
                    even = rng.Next(min, (max + 1));
                } while (even % 2 != 0);
                Console.WriteLine("The next generated number was (even): " + even);
            }
            else if (c == ConsoleKey.O)
            {
                int odd = rng.Next(min, (max + 1));
                do
                {
                    odd = rng.Next(min, (max + 1));
                } while (odd % 2 == 0);
                Console.WriteLine("The next generated number was (odd): " + odd);
            }
            else if (c == ConsoleKey.Enter)
            {
                int number2 = rng.Next(min, (max + 1));
                Console.WriteLine("The next generated number was (random): " + number2);
            }
            else if (c == ConsoleKey.I)
            {
                PrintInfo();
            }
            else if (c == ConsoleKey.C)
            {
                Console.Clear();
            }
            Console.Beep();  // beep :>
        }
        while (c != ConsoleKey.Escape);
    }
    public static void PrintInfo()
    {
        Console.WriteLine("Press ENTER if you want to change your number. ");
        Console.WriteLine("Press Escape if you want to stop the program.");
        Console.WriteLine("Press S if you want to generate even numbers only.");
        Console.WriteLine("Press O if you want to generate odd numbers only.");
        Console.WriteLine("Press N if you want to generate numbers that are divisors of 3.");
        Console.WriteLine("Press I at any time to get information about those commands.");
        Console.WriteLine("Press C to clear all console text.");
    }
}
