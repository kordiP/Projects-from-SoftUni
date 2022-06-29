using System;

namespace tf_this_mf_want_dawg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sn1 = "12345";
            string sn2 = "123";

            int MaxLength = Math.Max(sn1.Length, sn2.Length); //5

            int[] an1 = new int[MaxLength];
            int[] an2 = new int[MaxLength];

            for (int i = sn1.Length - 1; i >= 0; i--)
                an1[i] = sn1[i] - '0';
            for (int i = sn2.Length - 1; i >= 0; i--)
                an2[i] = sn2[i] - '0';

            //for (int i = 0; i < sn1.Length; i++)
            //    an1[MaxLength - 1 - i] = sn1[sn1.Length - 1 - i] - '0';
            //for (int i = 0; i < sn2.Length; i++)
            //    an2[MaxLength - 1 - i] = sn2[sn2.Length - 1 - i] - '0';
            Console.WriteLine(String.Join("", an1));
            Console.WriteLine(String.Join("", an2));
        }
    }
}
