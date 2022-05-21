// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vuvedete 2 chisla: ");
int s = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int a = m - s;
int k = Math.Abs(a);
for (int i = 0; i <= k; i++)
{
    Console.Write(s);
    s = s + a / k;
}
