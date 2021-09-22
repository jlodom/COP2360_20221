using System;
using System.Collections.Generic; /* Have to bring in Collections. */

namespace Week6_Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            /* List Example */
            List<double> listDouble = new List<double>(); /* Standard way of initalizing empty list of doubles. */
            List<double> listDoubleFromOven = new List<double>{7.1, 6.5, 31.6, 27.9, 4.5 };
            if (listDoubleFromOven.Contains(6.5))
            {
                Console.WriteLine("Yes, 6.5 is a number in the list.");
            }

            /* Dictionary Example */
            Dictionary<String, double> dicPeopleHeight = new Dictionary<string, double>();
            dicPeopleHeight.Add("Cruise", 67);
            dicPeopleHeight.Add("Lynch", 72);
            dicPeopleHeight.Add("Shaq", 85);
            dicPeopleHeight.Add("Christie", 75);
            dicPeopleHeight.Add("Devito", 58);
            if (dicPeopleHeight.ContainsKey("Devito"))
            {
                Console.WriteLine("Danny Devito is " + dicPeopleHeight["Devito"] + " inches tall");
            }
            if (dicPeopleHeight.ContainsValue(72))
            {
                /* Illustrating use of dictionary with a foreach loop. */
                foreach (KeyValuePair<String, double> rowFromDic in dicPeopleHeight)
                {
                    if(rowFromDic.Value == 72)
                    {
                        Console.WriteLine(rowFromDic.Key + " is 72 inches tall");
                    }
                }
            }





        }
    }
}
