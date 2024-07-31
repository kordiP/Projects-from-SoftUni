using System.Linq;

namespace Exams
{
    internal class Program
    {
        static List<string> result = new List<string>(); 
        static void Main()
        {
            string[] input = Console.ReadLine().Split(", ");
            string[] friendsNames = input;

            string[] allCombinations = GenPermutations(friendsNames, 0).ToArray();

            List<string> validCombinations = allCombinations.ToList();
            Dictionary<int, string> seatsTaken = new Dictionary<int, string>();

            input = Console.ReadLine().Split(" - ");

            while (input[0] != "generate")
            {
                string nameOfFriend = input[0];
                int seatNumber = int.Parse(input[1]);

                seatsTaken.Add(seatNumber, nameOfFriend);

                input = Console.ReadLine().Split(" - ");
            }            
            for (int i = 0; i < allCombinations.Length; i++)  
            {
                string[] currentCombo = allCombinations[i].Split(" ");
                // 1 Amy  4 Rick
                foreach (var item in seatsTaken)
                {
                    if (currentCombo[item.Key - 1] != item.Value)                    
                       validCombinations.Remove(allCombinations[i]);                    
                }
            }
            Console.WriteLine(String.Join("\n", validCombinations));
        }
        static List<string> GenPermutations(string[] arr, int index)
        {
            if (index == arr.Count() && !result.Contains(String.Join("", arr)))
                result.Add(String.Join(" ", arr));
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
            return result;
        }
    }
}