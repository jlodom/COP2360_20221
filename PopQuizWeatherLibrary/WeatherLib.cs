using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PopQuizWeatherLibrary
{
    public class WeatherLib
    {
        Dictionary<DateTime, double> WeatherData = new Dictionary<DateTime, double>();

        public WeatherLib(String pathToWeatherFile)
        {
            String[] arrayStringLines = File.ReadAllLines(pathToWeatherFile);
            List<String> listStringLines = arrayStringLines.ToList<String>(); /* Needed Linq. This was just for fun--arrays would also be fine. */

            Boolean boolIsNotFirstLine = false; /* We need to skip the first line because it is the header. */
            foreach (String stringLine in listStringLines)
            {
                if (boolIsNotFirstLine) /* Every line but the first */
                {
                    String[] arrayStringOneLine = stringLine.Split(',');

                    double dblTemp = Double.Parse(arrayStringOneLine[3]); /* We would use TryParse here, but we want trouble so we can review CH.12 */
                    int intYear = int.Parse(arrayStringOneLine[0]);
                    int intMonth = int.Parse(arrayStringOneLine[1]);
                    int intDay = int.Parse(arrayStringOneLine[2]);
                    DateTime dtTheDate = new DateTime(intYear, intMonth, intDay);
                    this.WeatherData.Add(dtTheDate, dblTemp); /* Load the data into our long-lived dictionary. */
                }
                else
                {
                    boolIsNotFirstLine = true; /* If it is the first line, flip the boolean so we know the next line is NOT first. */
                }

            }

        }

    }
}
