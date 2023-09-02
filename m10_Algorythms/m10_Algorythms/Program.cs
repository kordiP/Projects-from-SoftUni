namespace m10_Algorythms
{
    internal class Program
    {
        static void Main()
        {
            int wantedSum = 48;
            int[] coinsValues = new int[] { 25, 10, 5, 1 };
            int currentSum = 0;
            Queue<int> coinsNeeded = new Queue<int>(); 

            while (currentSum!=wantedSum) 
            {
                for (int i = 0; i < coinsValues.Count(); i++)
                {
                    if (!(currentSum + coinsValues[i] > wantedSum))
                    {
                        coinsNeeded.Enqueue(coinsValues[i]);
                        break;
                    }
                }
                currentSum = coinsNeeded.Sum();
            }
            foreach (var item in coinsNeeded)
            {
                Console.Write(item + " ");
            }
        }
    }
}