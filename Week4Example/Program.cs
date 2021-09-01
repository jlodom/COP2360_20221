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
            /* This is not required yet. */
            String[] stringArrayAllLines = File.ReadAllLines("C:\\Users\\jodom\\Downloads\\Pensacola Data Snapshot.csv");
            Boolean boolNotFirstRow = false;
            List<String> listStringHeaders = new List<string>();
            List<Dictionary<String, String>> spreadsheet = new List<Dictionary<string, string>>();
            foreach (String line in stringArrayAllLines)
            {
                if (boolNotFirstRow)
                {
                    Dictionary<String, String> dicStringTemp = new Dictionary<string, string>();
                    String[] stringArrayData = line.Split(',');
                    int i = 0;
                    foreach (String stringHeader in listStringHeaders)
                    {
                        dicStringTemp.Add(stringHeader, stringArrayData[i]);
                        i++;
                    }
                    spreadsheet.Add(dicStringTemp);
                }
                else
                {
                    listStringHeaders = line.Split(',').ToList<String>();
                }
                boolNotFirstRow = true;
            }
        }
    }
}