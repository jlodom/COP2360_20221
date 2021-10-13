using System;
using PopQuizWeatherLibrary;

namespace PopQuizWeatherTester
{
    class Program
    {
        static void Main(string[] args)
        {
            String goodInput = "C:\\Users\\jodom\\source\\repos\\COP2360_20221\\pop_quiz_20210928\\pensacola_temperatures.csv";
            String badInput = "C:\\Garbage\\";
            WeatherLib wl = new WeatherLib(goodInput);
            Console.WriteLine("Year with the Lowest Number of Temps Under 70 is " + wl.GetYearUnder70());
        }
    }
}
