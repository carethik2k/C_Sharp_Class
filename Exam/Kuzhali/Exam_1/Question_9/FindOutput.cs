using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_9
{
    class FindOutput
    {
        private static double input;
        private static string result;
        public static void FindOutput1()
        {
           Console.Write("Please enter a number: ");
            input = UserInput.AcceptNumberInput();
            result = (input % 2 == 0) ? "even" : "odd";
            Console.WriteLine("The number entered "+ input + " is "  +  result);

        }

    }
}
