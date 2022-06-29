Console.Write("Centuries = ");
int century = int.Parse(Console.ReadLine());
int year = century * 100;
int days = Convert.ToInt32(year * 365.2422);
int hours = days * 24;
int minutes = hours * 60;
Console.WriteLine($"{century:0} centuries = {year:0} years = {days:0} days = {hours:0} hours = {minutes:0} minutes");