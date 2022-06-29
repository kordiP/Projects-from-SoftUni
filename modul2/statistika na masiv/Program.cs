int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int i_max = array[0];
int i_avr = 0;
int i_min = array[0];
int i_sum = 0;
int i;
for (i = 0; i <= array.Length - 1; i++)
{
    if (i_max < array[i])
    {
        i_max = array[i];
    }
    if (i_min > array[i])
    {
        i_min = array[i];
    }
    i_sum = i_sum + array[i];
}
i_avr = i_sum / i;
Console.WriteLine($"Max = {i_max},  Min = {i_min}, Sum = {i_sum}, Avr = {i_avr}");