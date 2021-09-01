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
            foreach (String line in stringArrayAllLines)
            {
                if (boolNotFirstRow)
                {
                    Dictionary<String, String> dicStringTemp = new Dictionary<string, string>();
                    String[] stringArrayData = line.Split(',');
                    int i = 0;
                    foreach (String stringHeader in listStringHeaders)
                    {
                        dicStringTemp.Add(stringHeader, stringArrayData[i].Trim('"'));
                        i++;
                    }
                    spreadsheet.Add(dicStringTemp);
                }
                else
                {
                    listStringHeaders = line.Replace("\"", "").Split(',').ToList<String>();
                }
                boolNotFirstRow = true;
            }
            /* END HAND WAVING. */

            /* OKAY, A LITTLE MORE HAND-WAVING */
            String stringLegalFY2019 = spreadsheet[13]["FY 2019 Approved Budget"];
            String stringLegalFY2020 = spreadsheet[13]["FY 2020 Approved Budget"];
            /* END FURTHER HAND WAVING */
            double doubleLegalFY2019 = Double.Parse(stringLegalFY2019);
            double doubleLegalFY2020 = Double.Parse(stringLegalFY2020);
        }

        /* Look! A Method! Like in Chapter 3! Using the sorts of calculations we do in Chapter 2! */
        public static double GetPercentChange(double doubleBaseNumber, double doubleChangeNumber)
        {
            double doublePercentage = (doubleChangeNumber - doubleBaseNumber) / doubleBaseNumber;
            return doublePercentage;
        }

    }
}