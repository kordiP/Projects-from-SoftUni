namespace Fibounachi
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int fibonachiNumber = FibonachiRecoursiveAlgorithm(number);
            Console.WriteLine(fibonachiNumber);
        }
        static int FibonachiRecoursiveAlgorithm(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }
            return FibonachiRecoursiveAlgorithm(number - 1) + FibonachiRecoursiveAlgorithm(number - 2);
        }
    }
}