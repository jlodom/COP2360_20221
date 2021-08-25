/* Chapter 3 Example
 * Import Whatever Libraries or Packages We Need */
using System;
using System.IO;

/* Many different classes can share a namespace. */
namespace COP2360_20221 {
	class Program {

		/* Let's talk about Methods
		 * Main - Is the Name of this method.
		 * void - Is the data type returned (in this case nothing)
		 * In the parentheses are the parameters/arguments - the input
		 * static - can be omitted. 
		 *		Means we can use this method without creating an object.
		 */
		static void Main(string[] args) {
			Console.Write("Enter a string to repeat: ");
			String stringMethodInput = Console.ReadLine();
			Boolean boolKeepAsking = true;
			int intTimesToRepeat = -1;
			/* We have not covered while loops yet. */
			while (boolKeepAsking)
            {
				Console.Write("\nEnter the number of times to repeat it: ");
				/* The return is the boolean, but we also change intTimesToRepeat by using "out" to reference it. */
				boolKeepAsking = (!Int32.TryParse(Console.ReadLine(), out intTimesToRepeat));
			}
			/* Call our method here -- this is the meat of the program. */
			String stringRepeated = StringRepeater(stringMethodInput, intTimesToRepeat);
			Console.WriteLine("Output: " + stringRepeated);
			Console.WriteLine("This is just here to have a final breakpoint.");
		}

		/* An example method. */
				static String StringRepeater
			(String stringToRepeat, int intNumTimesToRepeat) /*Input*/
        {
			/* Declare our output to be safe about things. */
			String stringFinal = String.Empty;
			/* Actual Programming / Logic Goes Here */
			for (int i = 0; i < intNumTimesToRepeat; i++)
			{ 
				stringFinal += stringToRepeat;

			}
			/* Output / Return */
			return stringFinal;
        }

	}
}
