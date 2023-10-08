namespace CrushNumbers
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BySubtraction(new int[number], 0, number, 0, number);
        }
        static void BySubtraction(int[] currNumbers, int count, int number, int sum, int original)
        {
            sum += number;
            if (sum < original)
            {
                if (currNumbers[count] == number) 
                    BySubtraction(currNumbers, count, number - 1, sum - 1, original);

                currNumbers[count] = number;
                BySubtraction(currNumbers, count + 1, number - 1, sum, original);
            }
            else if (sum > original) 
            {
                sum -= number;
                BySubtraction(currNumbers, count, number - 1, sum, original);
            }
            else
            {
                currNumbers[count] = number;
                count = 0;
                Console.Write(original + " = " + currNumbers[0]);
                count++;
                for (int i = 1; i < currNumbers.Length; i++)
                {
                    if (currNumbers[i] != 0)
                    {
                        Console.Write(" + " + currNumbers[i]);
                        count++;
                    }
                }
                Console.WriteLine();
                BySubtraction(currNumbers, 0, original - count, 0, original);
            }
        }
    }
}