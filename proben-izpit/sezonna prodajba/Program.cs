string model = Console.ReadLine();
string type = Console.ReadLine();
string sezon = Console.ReadLine();
string con = Console.ReadLine();
double cena = double.Parse(Console.ReadLine());
double jelana_cena = double.Parse(Console.ReadLine());
double profit;
if (type.ToUpper() == "SUV")
{
    if (sezon=="winter")
    {
        if (con=="perfect")
        {
            profit = cena * 0.3 - 200;
            if (profit > jelana_cena)
            {
                Console.WriteLine($"The profit on {model} will be good - {profit:0.00} BGN");
            }
            else
            {
                Console.WriteLine("The car is not worth selling now");
                Console.WriteLine($"Need {jelana_cena - profit:0.00} more profit");
            }
        }
        else if (con == "good")
        {
            profit = 0.2 * cena  - 200;
            if (profit > jelana_cena)
            {
                Console.WriteLine($"The profit on {model} will be good - {profit:0.00} BGN");
            }
            else
            {
                Console.WriteLine("The car is not worth selling now");
                Console.WriteLine($"Need {jelana_cena - profit:0.00} more profit");
            }
        }
        else if (con=="bad")
        {
            profit =  cena * 0.10 - 200;
            if (profit > jelana_cena)
            {
                Console.WriteLine($"The profit on {model} will be good - {profit:0.00} BGN");
            }
            else
            {
                Console.WriteLine("The car is not worth selling now");
                Console.WriteLine($"Need {jelana_cena - profit:0.00} more profit");
            }
        }
        
    }
    else
    {
        profit = cena*0.25;
        if (profit > jelana_cena)
        {
            Console.WriteLine($"The profit on {model} will be good - {profit:0.00} BGN");
        }
        else
        {
            Console.WriteLine("The car is not worth selling now");
            Console.WriteLine($"Need {jelana_cena - profit:0.00} more profit");
        }
    }
}
else if (type.ToLower() == "sedan")
{
    if (sezon == "winter")
    {
        if (con == "perfect")
        {
            profit = cena * 0.25 - 200;
            if (profit > jelana_cena)
            {
                Console.WriteLine($"The profit on {model} will be good - {profit:0.00} BGN");
            }
            else
            {
                Console.WriteLine("The car is not worth selling now");
                Console.WriteLine($"Need {jelana_cena - profit:0.00} more profit");
            }
        }
        else if (con == "good")
        {
            profit = 0.15 * cena - 200;
            if (profit > jelana_cena)
            {
                Console.WriteLine($"The profit on {model} will be good - {profit:0.00} BGN");
            }
            else
            {
                Console.WriteLine("The car is not worth selling now");
                Console.WriteLine($"Need {jelana_cena - profit:0.00} more profit");
            }
        }
        else if (con == "bad")
        {
            profit = cena * 0.10 - 200;
            if (profit > jelana_cena)
            {
                Console.WriteLine($"The profit on {model} will be good - {profit:0.00} BGN");
            }
            else
            {
                Console.WriteLine("The car is not worth selling now");
                Console.WriteLine($"Need {jelana_cena - profit:0.00} more profit");
            }
        }

    }
    else
    {
        profit = cena * 0.25;
        if (profit > jelana_cena)
        {
            Console.WriteLine($"The profit on {model} will be good - {profit:0.00} BGN");
        }
        else
        {
            Console.WriteLine("The car is not worth selling now");
            Console.WriteLine($"Need {jelana_cena - profit:0.00} more profit");
        }
    }
}
