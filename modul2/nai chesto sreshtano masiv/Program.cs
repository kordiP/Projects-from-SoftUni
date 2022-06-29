//Console.Write("broi elementi: ");
//int n = int.Parse(Console.ReadLine());
//int[] a = new int[n];
////for (int i = 0; i < a.Length; i++)
////{
////    a[i] = int.Parse(Console.ReadLine());
////}
// PURVI NACHIN ^^^
string values = Console.ReadLine(); //vuvejdame stoinost
string[] items = values.Split(' '); //stringov masiv, razdelqsht elementite ot gorniq string (sus znak po nashe jelanie)
int[] arr = new int[items.Length]; //int masiv, koito vzima broq na razdelenite elementi
for (int i = 0; i < items.Length; i++)
{
    arr[i] = int.Parse(items[i]);
    Console.WriteLine(arr[i]);
}
