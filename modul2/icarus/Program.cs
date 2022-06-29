int[] plane = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int pos = int.Parse(Console.ReadLine());
int initial_dmg = 1;
string[] movement = Console.ReadLine().Split();
while (movement[0] != "Supernova")
{
    int znak = 1;
    if (movement[0] == "left")
        znak = -1;
    int num_of_mvm = int.Parse(movement[1]);
    for (int i = 0; i < num_of_mvm; i++)
    {
        pos = pos + znak;
        if (pos > plane.Length - 1)
        {
            pos = 0;
            initial_dmg++;
        }
        else if (pos < 0)           
        {
            pos = plane.Length - 1;
            initial_dmg++;
        }
        plane[pos] = plane[pos] - initial_dmg;
    }
    movement = Console.ReadLine().Split();
}
Console.WriteLine(String.Join(" ", plane));