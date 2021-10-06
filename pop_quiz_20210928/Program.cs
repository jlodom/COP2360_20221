using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace pop_quiz_20210928
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Read the assignment and think of the EASIEST, FIRST thing we need to do in the program.
             * In this case it would be read the file. */
            /* We should really pass this as an argument, but that's a later class .... */
            String stringPathToWeatherFile = "C:\\Users\\jodom\\source\\repos\\COP2360_20221\\pop_quiz_20210928\\pensacola_temperatures.csv";
            String[] arrayStringLines = File.ReadAllLines(stringPathToWeatherFile);
            List<String> listStringLines = arrayStringLines.ToList<String>(); /* Needed Linq. This was just for fun--arrays would also be fine. */

            /* We need a variable to store all of our data. 
             * We could do this MANY ways, but for compactness we will use dates and temps
             * And we will throw them together in a Dictionary so we have ONE variable. 
             * Keys have to be unique, and we know dates are unique in the file so they get to be the key.
             * That makes the temps the value.
             */
            Dictionary<DateTime, double> dicData = new Dictionary<DateTime, double>();
            Dictionary<int, int> dicLowestYear = new Dictionary<int, int>();
            Dictionary<int, int> dicMostTempsUnderSeventy = new Dictionary<int, int>();

            /* If dealing with collections (lists, arrays) we need a loop to go through them.
             * I like foreach loops. */
            Boolean boolIsNotFirstLine = false; /* We need to skip the first line because it is the header. */
            foreach (String stringLine in listStringLines)
            {
                if (boolIsNotFirstLine) /* Every line but the first */
                {
                    String[] arrayStringOneLine = stringLine.Split(',');

                    /* We have broken the file into little strings. Now we really load the data. */
                    double dblTemp = Double.Parse(arrayStringOneLine[3]); /* We would use TryParse here, but we want trouble so we can review CH.12 */
                    /* We could do this in one line, but let's go long. */
                    int intYear = int.Parse(arrayStringOneLine[0]);
                    int intMonth = int.Parse(arrayStringOneLine[1]);
                    int intDay = int.Parse(arrayStringOneLine[2]);
                    DateTime dtTheDate = new DateTime(intYear, intMonth, intDay);
                    dicData.Add(dtTheDate, dblTemp); /* Load the data into our long-lived dictionary. */

                    /* Piggyback on the loop we already wrote to do #1 and #2
                     * We check to see if we already have the year in our dictionaries.
                     If we do have it, we add one to the current value.
                    If we do not have it, we set it to one since this is the first time.*/
                    if (dicLowestYear.ContainsKey(intYear))
                    {
                        dicLowestYear[intYear]++;
                    }
                    else
                    {
                        dicLowestYear[intYear] = 1;
                    }

                    if(dblTemp < 70) /* MAGIC NUMBER -- BAD! */
                    {
                        if (dicMostTempsUnderSeventy.ContainsKey(intYear))
                        {
                            dicMostTempsUnderSeventy[intYear]++;
                        }
                        else
                        {
                            dicMostTempsUnderSeventy[intYear] = 1;
                        }
                    }

                }
                else
                {
                    boolIsNotFirstLine = true; /* If it is the first line, flip the boolean so we know the next line is NOT first. */
                }
               
            }

            /* Out of the for loop, all of our data is now in a convenient format -- our dictionary. */
            Console.WriteLine(dicData.Count);
            KeyValuePair<int, int> kvpBelowSeventy = dicMostTempsUnderSeventy.Max(); /* This throws as exception. WILL FIX NEXT WEEK */
            Console.WriteLine("The year with the most temps below 70 was " + kvpBelowSeventy.Key + " with " + kvpBelowSeventy.Value);
            KeyValuePair<int, int> kvpMinimumObservations = dicLowestYear.Min();
            Console.WriteLine("The year with the fewest observations was " + kvpMinimumObservations.Key + " with " + kvpMinimumObservations.Value);
            Console.WriteLine("End Program");

        }
    }
}
/*
 * Pop Quiz:

You will get up to 10 points at the discretion of the instructor for working through the following tasks in class, asking for assistance, and otherwise asking clarifying questions that the entire class can learn from.

Write a C# program that reads in the file "pensacola_temperatures.csv" and stores the dates and temperatures in a way that allows you to write methods that produce the following outputs:

1. Which year has the fewest temperature observations?
2. Which year (or years, if a tie) had the most temperatures under 70 degrees?
3. If the user inputs a year, print out the average temperature for each month of that year.
4. If a user inputs two dates, print the temperatures and dates for every day between those two dates (including the start and stop days)

To store your data you can use many types of collections including dictionaries and lists (you will probably not use both dictionaries AND lists).

The following page of constructors might help with parsing dates:
https://docs.microsoft.com/en-us/dotnet/api/system.datetime.-ctor?view=net-5.0

You will find the File.ReadAllLines , String.split (with "',' as the splitter), and various Parse methods useful when reading the data file. */