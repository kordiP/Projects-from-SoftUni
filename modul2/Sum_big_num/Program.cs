string Number1 = Console.ReadLine();
string Number2 = Console.ReadLine();
int[] ArrayNumber1;
int[] ArrayNumber2;
int ArrayDifference1 = 0;
int ArrayDifference2 = 0;
if (Number1.Length > Number2.Length)
{
    ArrayDifference1 = Number1.Length - Number2.Length;
    ArrayNumber1 = new int[Number1.Length];
    ArrayNumber2 = new int[Number1.Length];
    for (int i = ArrayDifference2; i <= ArrayNumber1.Length - 1; i++)
        ArrayNumber1[i] = Number1[i] - '0';
    for (int i = 0; i <= Number2.Length - 1; i++)
        ArrayNumber2[i + ArrayDifference1] = Number2[i] - '0';
}
else if (Number1.Length < Number2.Length)
{
    ArrayDifference2 = Number2.Length - Number1.Length;
    ArrayNumber1 = new int[Number2.Length];
    ArrayNumber2 = new int[Number2.Length];
    for (int i = ArrayDifference1; i <= ArrayNumber2.Length - 1; i++)
        ArrayNumber2[i] = Number2[i] - '0';
    for (int i = 0; i <= Number1.Length - 1; i++)
        ArrayNumber1[i + ArrayDifference2] = Number1[i] - '0';
}
else
{
    ArrayNumber1 = new int[Number1.Length];
    ArrayNumber2 = new int[Number2.Length];
    for (int i = ArrayDifference2; i <= ArrayNumber1.Length - 1; i++)
        ArrayNumber1[i] = Number1[i] - '0';
    for (int i = ArrayDifference1; i <= ArrayNumber2.Length - 1; i++)
        ArrayNumber2[i] = Number2[i] - '0';
}
int[] ArraySum;
if (ArrayNumber1.Length > ArrayNumber2.Length)
    ArraySum = new int[ArrayNumber1.Length + 1];
else
    ArraySum = new int[ArrayNumber2.Length + 1];
bool NaUm = false;
for (int i = ArraySum.Length - 1; i >= 0; i--)
{
    if (i < ArrayNumber1.Length && i < ArrayNumber1.Length)
    {
        ArraySum[i + 1] = ArrayNumber1[i] + ArrayNumber2[i];
        if (NaUm == true)
        {
            ArraySum[i + 1]++;
            NaUm = false;
        }
        else
            NaUm = false;
        if (ArraySum[i + 1] > 9)
        {
            NaUm = true;
            ArraySum[i + 1] = ArraySum[i + 1] - 10;
        }
    }
    else
        ArraySum[0] = 1;
}
if (NaUm == false)
    for (int i = 1; i <= ArraySum.Length - 1; i++)
    {
            Console.Write(ArraySum[i]);
    }
else
    for (int i = 0; i <= ArraySum.Length - 1; i++)
    {       
            Console.Write(ArraySum[i]);        
    }
