int input;
int s = 0;
int[] a = { 1,2,3 };
for (int i = 0; i < a.Length;i++)
{
    input = a[i];
    s += input;
}
Console.Write("Sborut na 1,2 i 3 e: ");
Console.WriteLine(s);
