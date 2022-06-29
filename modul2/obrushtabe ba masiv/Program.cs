//int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int n = a.Length;
//int m = n / 2;
//for (int i = 0; i < m; i++)
//{
//    int temporary = a[i];
//    a[i] = a[n - 1 - i];
//    a[n - 1 - i] = temporary;
//}
//for (int i = 0; i < n; i++)
//{
//    Console.Write($"{a[i]} ");
//}
// ^^^^^^^^^^^^^^^^^^^^ 1-st Way ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();
Array.Reverse(b);
for (int i = 0; i < b.Length; i++)
{
    Console.Write($"{b[i]} ");
}