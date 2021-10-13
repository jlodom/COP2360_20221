using System;
using PopQuizWeatherLibrary;

namespace PopQuizWeatherTester
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherLib wl = new WeatherLib("C:\\Users\\jodom\\source\\repos\\COP2360_20221\\pop_quiz_20210928\\pensacola_temperatures.csv");

            Console.WriteLine("Hello World!");
        }
    }
}
