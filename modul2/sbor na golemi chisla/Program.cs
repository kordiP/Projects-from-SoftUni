using System;
namespace sbor_na_golemi_chisla
{
    internal class Program
    {
        static void Main()
        {
            string sn1 = Console.ReadLine();
            string sn2 = Console.ReadLine();

            int MaxLength = Math.Max(sn1.Length, sn2.Length);

            int[] an1 = new int[MaxLength];
            int[] an2 = new int[MaxLength];
            int[] res = new int[MaxLength + 1];

            for (int i = 0; i < sn1.Length; i++)
                an1[MaxLength - 1 - i] = sn1[sn1.Length - 1 - i] - '0';
            for (int i = 0; i < sn2.Length; i++)
                an2[MaxLength - 1 - i] = sn2[sn2.Length - 1 - i] - '0';

            int x = 0;  
            for (int i = MaxLength - 1; i >= 0; i--)
            {
                int cs = an1[i] + an2[i] + x; 
                if (cs > 9)  // doubleDigit
                {
                    res[i + 1] = cs - 10; x = 1; 
                }
                else  // singleDigit
                {
                    res[i + 1] = cs; x = 0;
                } 
            }
            res[0] = x;
            int lzi = 0; // LeadingZeroIndex
            while (lzi < res.Length - 1 && res[lzi] == 0) lzi++;
            for (; lzi < res.Length; lzi++) 
                Console.Write(res[lzi]);
        }
    }
}
