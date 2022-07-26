Console.WriteLine("Vuvedete sumata na chislata: ");
double S = double.Parse(Console.ReadLine());
double n = 0;
double k = 1;
double suma = 0;
double znak = 1;
double poreden_chlen= (k / (2 * n + 1));
suma = suma + (k / (2 * n + 1));
n++;
while (poreden_chlen < S)
{
    poreden_chlen = (k / (2 * n + 1));
    znak = -znak;
    suma = suma + ((k / (2 * n + 1))) * znak;
    n++;
    Console.WriteLine(suma);
}
Console.WriteLine("Sumata na chislata e: " + suma);
Console.WriteLine("Stoinostta na poslednoto chislo e:" + poreden_chlen);