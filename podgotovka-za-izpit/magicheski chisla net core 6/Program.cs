int n = int.Parse(Console.ReadLine());
for (int c5 = 1; c5 < 10; c5++)
    for (int c4 = 1; c4 < 10; c4++)
        for (int c3 = 1; c3 < 10; c3++)
            for (int c2 = 1; c2 < 10; c2++)
                for (int c1 = 1; c1 < 10; c1++)
                    for (int c0 = 1; c0 < 10; c0++)
                        if (c0 * c1 * c2 * c3 * c4 * c5 == n)
                        {
                            Console.Write($"{c0}{c1}{c2}{c3}{c4}{c5} ");
                        }
