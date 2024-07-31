namespace _2019_WordCruncher
{
    internal class Program
    {
        static List<string> allPermutations = new List<string>();
        static void Main()
        {
            string[] wordsToCreate = Console.ReadLine().Split(", ");
            string stringToCrunch = Console.ReadLine();
            for (int i = 1; i < wordsToCreate.Count(); i++)
            {
                GenPermutations(wordsToCreate, 0);
            }
            
            foreach (var perm in allPermutations) 
            { 
                if (perm.Replace(" ","") == stringToCrunch) 
                {
                    Console.WriteLine(perm);
                }
            }

        }
        static List<string> GenPermutations
            (string[] arr, int index)
        {
            if (index == arr.Count() && !allPermutations.Contains(String.Join("", arr)))
                allPermutations.Add(String.Join(" ", arr));
            else
            {
                for (int i = index; i < arr.Length; i++)
                {
                    string tmp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = tmp;

                    GenPermutations(arr, index + 1);

                    tmp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = tmp;
                }
            }
            return allPermutations;
        }
    }
}