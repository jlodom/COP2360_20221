using System;
using System.IO;

namespace CommandLineExample
{
    class Program
    {
        static void Main(string[] args)
        {

            String candidateName = args[0]; /* Get Candidate Name From Argument 1 */
            String pathToInputFile = args[1]; /* Get Path to File From Argument 2 */

            string[] allLines = File.ReadAllLines(pathToInputFile);

            Console.WriteLine("First ten lines of " + pathToInputFile);
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(allLines[i]);
            }

            Console.WriteLine("Our candidate name is: " + candidateName);
        }

    }
}
