int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] field = new int[input.Length - 1];
int[] field_copy = new int[input.Length - 1];
for (int i = 0; i < input.Length - 1; i++)
{
    field[i] = input[i] - 1;
    field_copy[i] = input[i];
}
int st_pos = input[input.Length - 1];
int next_pos;
bool end_check = false;
int counter = 0;
while (end_check == false)
{
    next_pos = int.Parse(Console.ReadLine());
    for (int i = 0; i < field.Length; i++)
        field[i]--;
        if (field[next_pos] != 0)
    {
        for (int i = 0; i < field.Length; i++)
        {
            if (field[i] == 0)
            {
                field[i] = field_copy[i];
            }
        }
    }
    else
        end_check = true;
    counter++;
}
Console.WriteLine(String.Join(" ", field));
Console.WriteLine(counter);
