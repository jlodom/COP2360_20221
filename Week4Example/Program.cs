using System;
using System.IO; /* For Input-Output, see Ch13 */
using System.Collections.Generic;
using System.Linq;

namespace Week4Example
{
    class Program
    {
        static void Main(string[] args)
        {
            /* HAND WAVING. THIS IS NOT REQUIRED TO KNOW YET. */
            String[] stringArrayAllLines = File.ReadAllLines("C:\\Users\\jodom\\Downloads\\Pensacola Data Snapshot.csv");
            Boolean boolNotFirstRow = false;
            List<String> listStringHeaders = new List<string>();
            List<Dictionary<String, String>> spreadsheet = new List<Dictionary<string, string>>();
            /* Class 5 - We are ready to discuss loops. 
             * Taking each string (line) in the stringArrayAllLines collection (array) and doing something with it.
             * Computers are good at REPEATING instructions with DIFFERENT DATA. */
            foreach (String line in stringArrayAllLines)
            {
                /* DECISION - If/Else */
                if (boolNotFirstRow)
                {
                    Dictionary<String, String> dicStringTemp = new Dictionary<string, string>();
                    String[] stringArrayData = line.Split('|');
                    int i = 0;
                    /* NESTED REPEATING LOOP (i.e. another foreach inside our first foreach) */
                    foreach (String stringHeader in listStringHeaders)
                    {
                        dicStringTemp.Add(stringHeader, stringArrayData[i]);
                        i++;
                    }
                    spreadsheet.Add(dicStringTemp);
                }
                else
                {
                    listStringHeaders = line.Split("|").ToList<String>();
                }
                boolNotFirstRow = true;
            }
            /* END HAND WAVING. */

            /* This is where we start using objects. */
            BudgetCategory bcLegal = new BudgetCategory(spreadsheet[13]);
            Console.WriteLine("The percent different for 2018-2019 in legal was "
                + bcLegal.GetPercent1819());

        }

    }
}