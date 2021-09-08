﻿using System;
using System.Collections.Generic;

namespace Week5Example
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Various variables we will use. */
            Boolean boolDoWhileRun = true;
            Boolean boolWhileRun = true;
            int intCountOfTempsWhile = 0;
            int intCountOfTempsDoWhile = 0;
            double doubleTotalTemps = 0.0;
            /* Load our temperature data to a list (collection) of doubles */
            List<double> listDoubleTemps = LoadTemps();

            /* Regular While Example */
            while (intCountOfTempsWhile < listDoubleTemps.Count)
            {
                    doubleTotalTemps += listDoubleTemps[intCountOfTempsWhile];
                    intCountOfTempsWhile++;   
            }
            Console.WriteLine("The Average Temperature is: " + (doubleTotalTemps/ intCountOfTempsWhile));

            /* Do While Example - Get a count of how many doubles in the list. */
            do
            {
                try
                {
                    /* This double exists only to throw an exception. */
                    double doubleThrowAway = listDoubleTemps[intCountOfTempsDoWhile];
                    intCountOfTempsDoWhile++;
                }
                catch
                {
                    boolDoWhileRun = false;
                }
            } while (boolDoWhileRun);
            Console.WriteLine("The list has " + intCountOfTempsDoWhile + " doubles.");

            /* Classic For Example */
            /* Reset Variables */
            doubleTotalTemps = 0;
            intCountOfTempsWhile = 0;
            for (int i = 0; i < listDoubleTemps.Count; i++)
            {
                doubleTotalTemps += listDoubleTemps[intCountOfTempsWhile];
                intCountOfTempsWhile++;
            }
            Console.WriteLine("For Loop Version - The Average Temperature is: " + (doubleTotalTemps / intCountOfTempsWhile));

            /* Why We Still Have The For Loop */
            for(int j = 100; j > 0; j--)
            {
                Console.WriteLine(j + " bottles of soda on the wall.");
            }

            /* Foreach Loop Example (Use This Instead of For) */
            doubleTotalTemps = 0;
            intCountOfTempsWhile = 0;
            foreach (double temp in listDoubleTemps)
            {
                doubleTotalTemps += listDoubleTemps[intCountOfTempsWhile];
                intCountOfTempsWhile++;
            }
            Console.WriteLine("Foreach Loop Version - The Average Temperature is: " + (doubleTotalTemps / intCountOfTempsWhile));



        }

        public static List<double> LoadTemps()
        {
            List<double> temps = new List<double> { 84, 85.5, 86, 85, 85.5, 85.5, 85.5, 84, 83.5, 83.5, 84, 82, 85.5, 84.5, 84.5, 81, 81.5, 82, 85, 89, 87, 85.5, 86.5, 83.5, 83, 85.5, 86, 87.5, 85.5, 86, 84.5, 81.5, 82.5, 78.5, 79, 82, 84.5, 84.5, 84, 85, 83.5, 83, 84.5, 84.5, 84.5, 83.5, 84.5, 87, 87, 87, 85.5, 86.5, 82.5, 86, 86, 86, 85, 86, 82.5, 78.5, 82, 81.5, 84.5, 82.5, 82.5, 82, 82.5, 77, 74, 78, 78, 76.5, 67.5, 74.5, 73, 78, 80.5, 83.5, 82, 83.5, 84.5, 84, 83.5, 82.5, 83, 78.5, 80, 82.5, 84, 84, 84.5, 84.5, 76.5, 76.5, 81, 79, 78.5, 79.5, 82.5, 81, 82, 82, 84, 84, 82, 80.5, 81, 69.5, 68.5, 68.5, 73.5, 75.5, 77, 77.5, 68, 65.5, 60, 60.5, 69, 59.5, 51.5, 59.5, 63.5, 68.5, 75, 72.5, 74, 73, 74, 74.5, 73, 60, 60.5, 62.5, 62.5, 65, 62, 56.5, 62.5, 64.5, 71.5, 54.5, 50.5, 58.5, 60.5, 56.5, 57, 57.5, 59, 58, 58.5, 65, 67.5, 68, 66, 63, 65.5, 70, 52, 47, 40, 41, 44, 51, 53.5, 47, 54.5, 47.5, 50.5, 62, 73, 70, 69.5, 61.5, 71.5, 67, 58.5, 46.5, 49.5, 49.5, 45, 48.5, 49, 43, 32.5, 33.5, 39, 37, 41, 44, 47, 55.5, 61.5, 61.5, 65, 51.5, 37, 39, 47, 47.5, 28.5, 34, 42, 50.5, 56.5, 63, 56.5, 49, 52.5, 54.5, 61, 65, 57, 46, 50.5, 64, 52, 48, 62.5, 55, 59.5, 64.5, 57.5, 58, 65, 65.5, 61.5, 65.5, 64.5, 70.5, 74, 72.5, 70, 72.5, 72, 74, 73.5, 72, 73.5, 72.5, 67.5, 66.5, 71, 73.5, 65.5, 62.5, 60.5, 65.5, 64, 52.5, 50.5, 51.5, 62.5, 67.5, 54.5, 52, 53.5, 53.5, 60.5, 71, 73, 74, 63.5, 58.5, 57, 57.5, 66.5, 73.5, 63.5, 63, 70.5, 73, 66.5, 63, 63, 70.5, 74, 62, 60, 63, 62, 55, 68.5, 69.5, 65.5, 64.5, 69.5, 73, 57, 57.5, 61, 72.5, 70.5, 62.5, 67, 72, 67.5, 67, 69, 69, 65.5, 69.5, 72.5, 67.5, 73, 72, 71.5, 72, 75, 76.5, 76.5, 77.5, 78.5, 78, 78, 78, 83.5, 80.5, 81.5, 82, 78.5, 81, 82, 81, 78.5, 80, 78, 78, 78.5, 79, 79.5, 78.5, 79.5, 81.5, 82, 82.5, 84.5, 85, 82, 74, 79.5, 82.5, 80.5, 81.5, 79, 79.5, 79.5, 80.5, 79, 77.5, 81.5, 82.5, 83.5, 85, 84.5, 85, 86, 86.5, 87.5, 84.5, 85, 84.5, 85.5, 83, 83.5, 83, 80.5, 83.5, 82.5, 81.5, 82, 82.5, 79.5, 82, 84.5, 84, 84, 84, 85.5, 84.5, 84.5, 82.5, 83.5, 84, 84.5, 89.5, 85.5, 84, 82.5, 83, 85, 83.5, 86.5, 84, 84, 81.5, 77, 77, 79, 82.5, 84, 84.5, 83, 83, 83.5, 83, 83, 85.5, 83, 83, 83.5, 82.5, 82.5, 80, 79, 80.5, 83.5, 82, 81, 81.5, 83, 84, 84, 85.5, 82, 80.5, 78, 80, 81.5, 81.5, 78.5, 77.5, 80, 80.5, 81.5, 81.5, 82, 81, 84, 83, 84.5, 87, 84.5, 84.5, 84, 84, 83.5, 83.5, 82.5, 82, 79.5, 81.5, 82, 82, 80.5, 82, 81.5, 81, 81.5, 81, 81.5, 81, 81, 81.5, 81, 83, 79, 74.5, 69.5, 71, 76, 81, 80.5, 76.5, 75, 75, 75.5, 65, 63, 68.5, 70.5, 69, 65.5, 61.5, 66.5, 75.5, 70.5, 77, 72, 61.5, 59.5, 65, 72.5, 74, 75.5, 75.5, 67, 52.5, 56, 67.5, 58.5, 44, 42.5, 48.5, 55, 58, 58, 56.5, 51, 53, 54.5, 65, 62, 56, 43.5, 44, 56, 70, 70, 67.5, 62.5, 51, 47, 44.5, 51.5, 58.5, 54.5, 42, 47.5, 47.5, 60, 62.5, 54.5, 54, 56, 54, 56, 58, 45.5, 47, 58.5, 54.5, 55.5, 59, 64, 67, 64.5, 69.5, 69.5, 71.5, 69, 66, 59, 56, 56, 57, 64, 54, 49, 48, 57, 57, 46.5, 47, 50, 51.5, 63, 60, 40.5, 45, 55.5, 63.5, 46.5, 45.5, 46.5, 47.5, 50.5, 46.5, 42.5, 48, 52.5, 58, 65, 64, 66, 69, 71, 58, 53.5, 59, 63.5, 64.5, 53.5, 55, 67, 71.5, 70.5, 63, 59, 66.5, 70.5, 70, 72.5, 63.5, 58, 62.5, 68, 66.5, 71, 72.5, 62, 45, 44.5, 45.5, 49.5, 67, 69, 75, 71.5, 66.5, 67, 70.5, 64, 55.5, 57.5, 55.5, 57, 57.5, 61, 59.5, 59, 60, 67.5, 59, 60.5, 60, 63, 66.5, 57.5, 57, 59.5, 62.5, 62, 67, 70.5, 73, 69.5, 71, 75, 72.5, 72.5, 75, 66, 61.5, 64.5, 67.5, 73, 63, 61.5, 62, 65, 67, 69, 68.5, 69, 64.5, 67.5, 68.5, 73.5, 74, 75, 76.5, 75.5, 74.5, 73, 75.5, 76.5, 76.5, 75, 78, 73, 74.5, 73, 73, 75.5, 76, 79, 78, 79.5, 78.5, 79, 80, 80.5, 83, 84, 82, 82, 81.5, 84.5, 85, 85.5, 83, 87, 87.5, 82, 77.5, 81.5, 80.5, 84, 82.5, 83.5, 80.5, 79.5, 80.5, 80, 82, 82, 81.5, 84, 86, 87.5, 86, 85.5, 87.5, 88, 83.5, 86, 81, 80.5, 82.5, 84.5, 86, 85, 86.5, 90, 90.5, 89, 87, 80, 84, 83.5, 85, 85, 86.5, 86, 85, 85, 85, 83, 79.5, 81.5, 82, 83.5, 81, 81, 82, 82, 81.5, 82.5, 82.5, 82.5, 84, 83, 81, 81.5, 81.5, 85, 85.5, 88, 85, 85, 85.5, 84.5, 86, 86, 83.5, 87, 83.5, 85.5, 83.5, 80, 82.5, 82.5, 83, 84, 84, 80, 81, 84.5, 84.5, 83.5, 83, 84, 85, 86.5, 86, 87.5, 83, 84, 89, 86.5, 85, 84.5, 85, 84, 84.5, 86, 84.5, 87, 89.5, 83.5, 81, 80.5, 80.5, 80, 82.5, 86, 86.5, 86.5, 83, 83, 84, 85, 84.5, 85.5, 85, 82, 81.5, 83.5, 81.5, 79.5, 79.5, 79.5, 75, 75.5, 79, 80, 71, 64.5, 61, 69, 72.5, 77, 67.5, 65, 65, 76.5, 72, 65.5, 65.5, 72, 76, 60, 51, 55, 57, 62, 71, 70.5, 71.5, 59, 57.5, 58.5, 64, 52, 42.5, 48.5, 55, 54, 56.5, 56, 57.5, 59, 60, 67.5, 65, 53.5, 52.5, 63, 73, 64, 63.5, 67, 63.5, 47, 44.5, 55, 54, 61, 61.5, 63, 68.5, 66.5, 48, 51.5, 54, 57.5, 62, 71.5, 57, 43.5, 47, 53.5, 52, 53, 54.5, 63, 62.5, 65, 67, 68, 71.5, 59, 53.5, 52.5};
            return temps;
        }

    }
}
