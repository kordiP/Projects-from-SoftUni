static bool MagicWordsCheck (string str1, string str2)
{
    int c1 = str1.ToCharArray().Distinct().ToList().Count();
    int c2 = str1.ToCharArray().Distinct().ToList().Count();
    return c1 == c2;
}
string[] input = Console.ReadLine().Split();
Console.WriteLine(MagicWordsCheck(input[0], input[1]).ToString().ToLower());