char[] bukvi = new char[26];
int k = 0;
for (char i = 'a'; i <= 'z'; i++)
{
    bukvi[k] = i;
    k++;
}
char[] bukva_ot_dumi = Console.ReadLine().ToCharArray();
char[] bukva_ot_duma = bukva_ot_dumi;
for (int i = 0; i < bukva_ot_duma.Length; i++)
    for (int j = 0; j < bukvi.Length; j++)
        if (bukva_ot_duma[i] == bukvi[j])
        {
            Console.WriteLine($"{bukva_ot_duma[i]} -> {j}");
        }
Console.WriteLine("Po azbuchen red: ");
Array.Sort(bukva_ot_duma);
for (int i = 0; i < bukva_ot_duma.Length; i++)
    Console.WriteLine($"Bukva {i + 1}: {bukva_ot_duma[i]}");