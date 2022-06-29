using System;
namespace Raincast
{
    internal class Program
    {
        static void Main()
        {
            string type = Console.ReadLine(); string source, forecast; int forecastCount = 0; string[] EveryForecast = new string[100];
            while (type != "Davai Emo")
            {
                string[] CorrectType = type.Split(' ');
                while (TypeChecker(type) != "no" && CorrectType[0] == "Type:")
                {
                    type = TypeChecker(type);
                    source = Console.ReadLine();
                    string[] CorrectSource = source.Split(' ');
                    while (CorrectSource[0] != "Source:")
                    {
                        source = Console.ReadLine();
                        CorrectSource = source.Split(' ');
                    }
                    forecast = Console.ReadLine();
                    string[] CorrectForecast = forecast.Split(' ');
                    while (ForecastChecker(forecast) == "!" || CorrectForecast[0] != "Forecast:")
                    {
                        forecast = Console.ReadLine();
                        CorrectForecast = forecast.Split(' ');
                    }
                    EveryForecast[forecastCount] = $"{type} {forecast.Replace("Forecast: ", "")} ~ {CorrectSource[1]}";
                    forecastCount++;
                }
                type = Console.ReadLine();
            }
            for (int i = 0; i < forecastCount; i++)
                Console.WriteLine(EveryForecast[i]);
        }
        static string TypeChecker(string type)
        {
            switch (type)
            {
                case "Type: Normal":
                    type = "(Normal)";
                    break;
                case "Type: Warning":
                    type = "(Warning)";
                    break;
                case "Type: Danger":
                    type = "(Danger)";
                    break;
                default:
                    type = "no";
                    break;
            }
            return type;
        }
        static string ForecastChecker(string forecast)
        {
            if (forecast.Contains("!") || forecast.Contains(".") || forecast.Contains(",") || forecast.Contains("?"))
                forecast = "!";
            return forecast;
        }
    }
}
