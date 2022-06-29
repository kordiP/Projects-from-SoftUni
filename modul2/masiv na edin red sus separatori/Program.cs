char[] separators = {',', ';', ' ' };
string[] s = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
int[] n = new int[s.Length];
for (int i = 0; i < s.Length; i++)
{ 
    n[i] = int.Parse(s[i]);
}
for (int i = 0; i < s.Length; i++)
{
    Console.WriteLine(n[i]);
}