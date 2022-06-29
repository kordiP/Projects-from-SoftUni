using System;
using System.Collections.Generic;
namespace phx_grid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('.');
            Dictionary<string, int> firstWords = new Dictionary<string, int>();
            int Counter = 0;
            bool check = false;
            while (input[0] != "ReadMe")
            {
                if (input.Length == 1)
                {
                    string word = input[0];
                    char[] reversedWordLetters = new char[word.Length];
                    for (int i = 0; i < reversedWordLetters.Length; i++)
                        reversedWordLetters[i] = word[word.Length - 1 - i];
                    string reversedWord = new string(reversedWordLetters);
                    if (reversedWord == word) Console.WriteLine("YES");
                    else Console.WriteLine("NO");
                    input = Console.ReadLine().Split('.');
                }
                else
                {
                    firstWords.Add(input[0], Counter);
                    Counter += 1;
                    for (int i = 1; i < input.Length; i++)
                    {
                        string reversedWord = WordReversing(input[i]);
                        if (firstWords.ContainsKey(reversedWord) && !firstWords.ContainsKey("_") && !firstWords.ContainsKey(" ") && !firstWords.ContainsKey("u\0009")) check = true;
                        else check = false;
                    }
                    firstWords.Remove(input[0]);
                    if (check) Console.WriteLine("YES");
                    else Console.WriteLine("NO");
                    input = Console.ReadLine().Split('.');
                }
            }
        }
        static string WordReversing(string word)
        {
            char[] reversedWordLetters = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
                reversedWordLetters[i] = word[word.Length - 1 - i];
            string reversedWord = new string(reversedWordLetters);
            return reversedWord;
        }
    }
}
