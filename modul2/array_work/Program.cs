string[] input = Console.ReadLine().Split(' ');
string[] command = Console.ReadLine().Split(' ');
while (command[0] != "END")
{
    switch (command[0])
    {
        case "Distinct":
            input = input.Distinct().ToArray();
            break;
        case "Reverse":
            Array.Reverse(input);
            break;
        case "Replace":
            if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < input.Length)
                input[int.Parse(command[1])] = command[2];
            else
                Console.WriteLine("Invalid input!");
            break;
        default:
            Console.WriteLine("Invalid input!");
            break;
    }
    command = Console.ReadLine().Split();
}
Console.WriteLine(String.Join(", ", input));
