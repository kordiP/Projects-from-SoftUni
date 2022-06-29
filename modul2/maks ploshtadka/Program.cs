int[] plo6tatka = Console.ReadLine().Split().Select(int.Parse).ToArray();
int currVal = plo6tatka[0];
int maxVal = currVal;
int currCount = 1;
int maxCount = currCount;
int currPos = 0;
int maxPos = currPos;
for (int i = 0; i < plo6tatka.Length; i++)
{
    if (plo6tatka[i] == currVal)
    {
        currCount++;
        if (currCount > maxCount)
        {
            maxCount = currCount;
            maxVal = currVal;
            maxPos = currPos;
        }

    }
    else
    {
        if (currCount > maxCount)
        {
            maxCount = currCount;
            maxVal = currVal;
            maxPos = currPos;
        }
        currCount = 1;
        currVal = plo6tatka[i];
        currPos = i;
    }
}
Console.WriteLine($"{maxCount} | {maxVal} | {maxPos}");