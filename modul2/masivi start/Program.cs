Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
int[] k = new int[n];
int j; int l;
for (int i = 0; i < k.Length; i++)
{
    Console.Write("element[{0}] = ", i);
    k[i] = int.Parse(Console.ReadLine());
}
for (j = 0; j < k.Length - 1; j++)
{
    Console.Write($"{k[j] }, ");
}
Console.WriteLine($"{k[j] } ");
for (l = k.Length - 1; l > 0; l--) 
{
    Console.Write($"{k[l]}, ");
}
Console.WriteLine($"{k[l]}");