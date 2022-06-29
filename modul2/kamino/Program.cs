//not mine lol
const string endCommand = "Clone them";
int DNA_Lenght = int.Parse(Console.ReadLine());
int[] BestDNA = new int[DNA_Lenght];
int BestSS = 0, BestLSI = DNA_Lenght, BestSum = 0;
int DNA_Number = 0, BestDNA_Number = 0;
bool BetterDNA;

string[] input = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries);
while (input[0] != endCommand)
{
    int[] DNA = input.Select(int.Parse).ToArray();
    DNA_Number++; BetterDNA = false;
    const int s = 1;
    int ci = 0, tc, mc = 0, ti = -1, mi = -1, sum = 0;
    while (ci < DNA.Length)
    {
        while (ci < DNA.Length && DNA[ci] != s) ci++;
        tc = 0; ti = ci;
        while (ci < DNA.Length && DNA[ci] == s)
        {
            ci++; tc++; sum++;
        }
        if (tc > mc)
        {
            mc = tc; mi = ti;
        }
    }

    if (mc > BestSS) BetterDNA = true;
    else if (mc == BestSS && mi < BestLSI) BetterDNA = true;
    else if (mc == BestSS && mi == BestLSI && sum > BestSum) BetterDNA = true;

    if (BetterDNA == true)
    {
        BestSS = mc; BestLSI = mi; BestSum = sum;
        BestDNA_Number = DNA_Number;
        for (int i = 0; i < DNA_Lenght; i++)
            BestDNA[i] = DNA[i];
    }

    input = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries);
}
Console.WriteLine($"Best DNA sample {BestDNA_Number} with sum: {BestSum}.");
Console.WriteLine(string.Join(" ", BestDNA));
