using System.Threading.Channels;

namespace permutations
{
    internal class Program
    {
        static void VariationFinder(string currentPattern, int currentSum, int num, int[] numbers)
        {
            if (num != numbers.Count())
            {
                VariationFinder(currentPattern + "+" + numbers[num], currentSum + numbers[num], num + 1, numbers);
                VariationFinder(currentPattern + "-" + numbers[num], currentSum - numbers[num], num + 1, numbers);
            }
            else
            {
                if (currentSum == 0) Console.WriteLine(currentPattern);
            }
        }
        static void Main()
        {
            int numCount = int.Parse(Console.ReadLine());
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            VariationFinder("", 0, 0, numbers);
        }
    }

}