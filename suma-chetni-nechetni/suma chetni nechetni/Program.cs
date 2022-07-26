// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
int s1=0, s2=0;
int k = n;
for (int i = 0; i <= k; i++)
{
    if (n % 2 == 0) 
    {
        s1 = s1 + n;
    }
    else
    {
        s2 = s2 + n;
    }
    n=n-1;
}
Console.WriteLine("s1= "+s1);
Console.WriteLine("s2= "+s2);
