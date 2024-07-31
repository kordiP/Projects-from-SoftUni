namespace ExamPreps
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

            List<string> permutations = new List<string>();
            permutations = GenPermutations(numbers, 0, permutations);
            

            List<string> result = new List<string>();          

            foreach (string s in permutations) 
            {
                int[] currNumbers = Array.ConvertAll(s.Trim().Split(' '), Convert.ToInt32);

                List<int[]> cutePairs = new List<int[]>();

                for (int i = 0; i < currNumbers.Length - 1; i++)
                    if (currNumbers[i] > currNumbers[i + 1])
                        cutePairs.Add(new int[] { currNumbers[i], currNumbers[i + 1] });

                if (cutePairs.Count % 2 == 0 && cutePairs.Count > 0)
                    result.Add(s);
            }

            Console.WriteLine(String.Join("\n", result));
        }
        static List<string> GenPermutations(int[] arr, int index, List<string> allPermutations)
        {
            if (index == arr.Count() && !allPermutations.Contains(String.Join("", arr)))
                allPermutations.Add(String.Join(" ", arr));
            else
            {
                for (int i = index; i < arr.Length; i++)
                {
                    int tmp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = tmp;

                    GenPermutations(arr, index + 1, allPermutations);

                    tmp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = tmp;
                }
            }
            return allPermutations;
        }
        static void Problem1()
        {
            int[] streetNumbers = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            int[] ordered = streetNumbers.OrderByDescending(x => x).ToArray();

            int sum = 0;
            sum += ordered[0] - ordered[1];
            sum += ordered[1] - ordered[2];

            Console.WriteLine(sum);
        }
    }
}