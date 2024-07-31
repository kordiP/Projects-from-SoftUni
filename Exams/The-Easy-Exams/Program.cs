namespace The_Easy_Exams
{
    internal class Program
    {
        static void Main()
        {
            //Bank();

            //Permutations();

            //Triangle();

            //PrimeNumbers();

            //FoodVouchers();

            //Multiplication();

            //StringPermutations();

            //InnerConnections();

            //DoubleFufu();

            //Fiyahs();
            string[] input = Console.ReadLine().Split(" ");

            int height = int.Parse(input[0]);
            int length = int.Parse(input[1]);

            int[,] forest = new int[height, length];


            for (int i = 0; i < height; i++)
            {
                input = Console.ReadLine().Split(" ");
                for (int j = 0; j < length; j++)
                {
                    forest[i, j] = int.Parse(input[j]);
                }
            }

            Console.WriteLine(CountConnectedOnes(forest));
            
        }
        static int CountConnectedOnes(int[,] array)
        {
            if (array == null || array.Length == 0)
                return 0;

            int n = array.GetLength(0);
            int m = array.GetLength(1);
            int total_count = 0;

            int[,] visited = new int[n, m];

            int[] dr = { -1, -1, -1, 0, 1, 1, 1, 0 };
            int[] dc = { -1, 0, 1, 1, 1, 0, -1, -1 };

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (array[row, col] == 1 && visited[row, col] == 0)
                    {
                        total_count++;
                        DFS(row, col);
                    }
                }
            }

            void DFS(int row, int col)
            {
                if (row < 0 || row >= n || col < 0 || col >= m || array[row, col] == 0 || visited[row, col] == 1)
                    return;

                visited[row, col] = 1;

                for (int i = 0; i < 8; i++)
                {
                    int newRow = row + dr[i];
                    int newCol = col + dc[i];
                    DFS(newRow, newCol);
                }
            }

            return total_count;
        }
        static void Bank()
        {
            int input = int.Parse(Console.ReadLine());
            int[] bankNotes = { 100, 50, 20, 10, 5, 2, 1 };

            int count = 0;
            int bankNoteIndex = 0;
            while (input > 0)
            {
                if (bankNotes[bankNoteIndex] <= input)
                {
                    input -= bankNotes[bankNoteIndex];
                    count++;
                }
                else
                    bankNoteIndex++;
            }
            Console.WriteLine(count);
        }
        static void Permutations()
        {
            int number = int.Parse(Console.ReadLine());
            List<string> permutations = new List<string>();
            int[] allNumbers = new int[number];
            for (int i = 0; i < number; i++)
                allNumbers[i] = i + 1;
            permutations = Gen(allNumbers, 0, permutations);
            Console.WriteLine(String.Join("\n", permutations));
            static List<string> Gen(int[] arr, int index, List<string> permutations)
            {
                if (index == arr.Length)
                {
                    permutations.Add(string.Join(" ", arr));
                }
                else
                {
                    for (int i = index; i < arr.Length; i++)
                    {
                        int tmp = arr[i];
                        arr[i] = arr[index];
                        arr[index] = tmp;

                        Gen(arr, index + 1, permutations);

                        tmp = arr[i];
                        arr[i] = arr[index];
                        arr[index] = tmp;
                    }
                }
                return permutations;
            }
        }
        static void Triangle()
        {
            int height = int.Parse(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void PrimeNumbers()
        {
            int count = int.Parse(Console.ReadLine());
            List<int> primes = new List<int>();

            for (int i = 1; i <= 100; i++)
                if (IsPrime(i))
                    primes.Add(i);

            for (int i = 0; i < count; i++)
                Console.WriteLine(primes[i]);

            static bool IsPrime(int num)
            {
                if (num == 1)
                    return false;

                for (int i = 2; i <= Math.Sqrt(num); i++)
                    if (num % i == 0)
                        return false;

                return true;
            }
        }
        static void FoodVouchers()
        {
            int days = int.Parse(Console.ReadLine());
            int[] vouchers = { 100, 20 };

            int grandTotalVoucher = days * 20;
            int count = 0;
            int voucherIndex = 0;
            while (grandTotalVoucher > 0)
            {
                if (vouchers[voucherIndex] <= grandTotalVoucher)
                {
                    grandTotalVoucher -= vouchers[voucherIndex];
                    count++;
                }
                else
                    voucherIndex++;
            }

            Console.WriteLine(count);
        }
        static void Multiplication()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Mult(Math.Max(number1, number2), Math.Min(number1, number2)));

            static int Mult(int number1, int number2)
            {
                if (number2 != 0)
                    return number1 + Mult(number1, number2 - 1);
                return 0;
            }
        }
        static void StringPermutations()
        {
            string[] symbols = Console.ReadLine().Split(" ");
            List<string> permutations = new List<string>();
            permutations = GenPermutations(symbols, 0, new List<string>());


            string possiblePermutation = Console.ReadLine();
            bool hadPerms = false;

            while (possiblePermutation != "end")
            {
                if (permutations.Contains(possiblePermutation))
                {
                    Console.WriteLine(possiblePermutation); // or put in list and output later whatever
                    hadPerms = true;
                }
                possiblePermutation = Console.ReadLine();
            }

            if (!hadPerms)
                Console.WriteLine("No permutations");
            static List<string> GenPermutations(string[] arr, int index, List<string> result)
            {
                if (index == arr.Count() && !result.Contains(String.Join("", arr)))
                    result.Add(String.Join("", arr));
                else
                {
                    for (int i = index; i < arr.Length; i++)
                    {
                        string tmp = arr[i];
                        arr[i] = arr[index];
                        arr[index] = tmp;

                        GenPermutations(arr, index + 1, result);

                        tmp = arr[i];
                        arr[i] = arr[index];
                        arr[index] = tmp;
                    }
                }
                return result;
            }
        }
        static void InnerConnections()
        {
            string input = Console.ReadLine();

            List<string> connections = new List<string>();
            List<string> output = new List<string>();
            List<string> connectionsReversed = new List<string>();

            while (input != "end")
            {
                connections.Add(input);
                input = Console.ReadLine();
            }

            for (int i = 0; i < connections.Count; i++)
            {
                char[] reverseConn = connections[i].ToCharArray();
                Array.Reverse(reverseConn);
                connectionsReversed.Add(new string(reverseConn));
            }

            for (int i = 0; i < connections.Count; i++)
            {
                connectionsReversed.RemoveAt(i);

                if (connectionsReversed.Contains(connections[i]))
                    output.Add(connections[i]);

                connectionsReversed.Insert(i, connections[i]);
            }
            if (output.Count > 0)
                Console.WriteLine(String.Join("\n", output));
            else
                Console.WriteLine("Disconnected");
        }
        static void DoubleFufu()
        {
            string inputWord = Console.ReadLine();

            Dictionary<int, string> allWords = new Dictionary<int, string>();
            int count = 0;

            for (int i = 'a'; i <= 'z'; i++) // a = 98 b = 99
            {
                for (int j = 'a'; j <= 'z'; j++)
                {
                    if (i != j)
                    {
                        count++;
                        allWords.Add(count, $"{Convert.ToChar(i)}{Convert.ToChar(j)}");
                    }
                }
            }
            if (allWords.ContainsValue(inputWord))
                Console.WriteLine(allWords.Where(x => x.Value == inputWord).First().Key);
            else
                Console.WriteLine("No FuFu");
        }
        static void Fiyahs()
        {
            string[] input = Console.ReadLine().Split(" ");

            int height = int.Parse(input[0]);
            int length = int.Parse(input[1]);

            int[,] forest = new int[height, length];


            for (int i = 0; i < height; i++)
            {
                input = Console.ReadLine().Split(" ");
                for (int j = 0; j < length; j++)
                {
                    forest[i, j] = int.Parse(input[j]);
                }
            }

            Console.WriteLine(CountConnectedOnes(forest));
            static int CountConnectedOnes(int[,] array)
            {
                if (array == null || array.Length == 0)
                    return 0;

                int n = array.GetLength(0);
                int m = array.GetLength(1);
                int total_count = 0;

                int[,] visited = new int[n, m];

                int[] dr = { -1, -1, -1, 0, 1, 1, 1, 0 };
                int[] dc = { -1, 0, 1, 1, 1, 0, -1, -1 };

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < m; col++)
                    {
                        if (array[row, col] == 1 && visited[row, col] == 0)
                        {
                            total_count++;
                            DFS(row, col);
                        }
                    }
                }

                void DFS(int row, int col)
                {
                    if (row < 0 || row >= n || col < 0 || col >= m || array[row, col] == 0 || visited[row, col] == 1)
                        return;

                    visited[row, col] = 1;

                    for (int i = 0; i < 8; i++)
                    {
                        int newRow = row + dr[i];
                        int newCol = col + dc[i];
                        DFS(newRow, newCol);
                    }
                }

                return total_count;
            }
        }
    }
}