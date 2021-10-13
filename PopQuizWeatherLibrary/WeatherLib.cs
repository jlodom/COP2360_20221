using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PopQuizWeatherLibrary
{
    public class WeatherLib
    {
        Dictionary<DateTime, double> WeatherData = new Dictionary<DateTime, double>();
        public bool DataIsReady = false;
        public String message = String.Empty;

        public WeatherLib(String pathToWeatherFile)
        {
            List<String> listStringLines = new List<string>();
            try /* Try to get through without an exception. */
            {
                String[] arrayStringLines = File.ReadAllLines(pathToWeatherFile);
                listStringLines = arrayStringLines.ToList<String>(); /* Needed Linq. This was just for fun--arrays would also be fine. */
            }
            catch(Exception e) /* If an exception happens we go here. */
            {
                DataIsReady = false;
                message = e.Message;
            }
            finally /* Optional */
            {
                this.message = this.message + " Got to Finally block.";
            }

            Boolean boolIsNotFirstLine = false; /* We need to skip the first line because it is the header. */
            foreach (String stringLine in listStringLines)
            {
                DataIsReady = true;
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

        public int GetYearUnder70()
        {
            int intFinalYear = 0;
            Dictionary<int, int> dicYearCounts = new Dictionary<int, int>();
            foreach (KeyValuePair<DateTime, double> kvp in this.WeatherData)
            {
                if (kvp.Value < 70)
                {
                    int year = kvp.Key.Year;
                    /* If the year does not exist yet in the Dictionary */
                    if (!(dicYearCounts.ContainsKey(year)))
                    {
                        dicYearCounts.Add(year, 1); /* Add the year to the dictionary with 1 temp */
                    }
                    else
                    {
                        dicYearCounts[year]++; /* Find the year and add one temp to it. */
                    }
                }
            }

            /* We are not cheating and using Linq tonight. */
            int lowestcount = 367;
            foreach (KeyValuePair<int, int> kvpFinal in dicYearCounts)
            {
                if(lowestcount > kvpFinal.Value)
                {
                    lowestcount = kvpFinal.Value;
                    intFinalYear = kvpFinal.Key;
                }
            }

            return intFinalYear;
        }

    }
}
