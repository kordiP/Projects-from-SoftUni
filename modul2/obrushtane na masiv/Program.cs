int[] masiv = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] oburnat = masiv;
for (int i = 0; i < masiv.Length; i++)
{
    oburnat[i] = masiv[i];
    Console.Write(oburnat[masiv.Length - 1 - i] + " ");
}
// ^^^^^^^^ obrushtane (5 3 2 7 --> 7 2 3 5)
int[] masiv_lqvo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int tmp_l = masiv_lqvo[masiv_lqvo.Length - 1];
for (int i = masiv_lqvo.Length - 1; i > 0; i--)
{
    masiv_lqvo[i] = masiv_lqvo[i - 1];
}
masiv_lqvo[0] = tmp_l;
Console.WriteLine($"{String.Join(" ", masiv_lqvo)}");
// ^^^^^^^ zavurtane na krainiq desen chlen otlqvo (5 3 2 7 --> 7 5 3 2)
int[] masiv_dqsno = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int tmp_d = masiv_dqsno[0];
for (int i = 0; i < masiv_dqsno.Length - 1; i++)
{
        masiv_dqsno[i] = masiv_dqsno[i + 1];
}
masiv_dqsno[masiv_dqsno.Length - 1] = tmp_d;
Console.WriteLine($"{String.Join(" ", masiv_dqsno)}");
// ^^^^^^^ zavurtane na krainiq lqv chlen otdqsno (5 3 2 7 --> 3 2 7 5)