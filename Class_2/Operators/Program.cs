using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();

            //Typecast to int
            int inputInt = 0;
            bool parseResult = Int32.TryParse(input, out inputInt);

            Console.WriteLine("On Pre-Increment :" + ++inputInt);
            Console.WriteLine("After Pre-Increment :" + inputInt);

            Console.WriteLine("On Post-Increment :" + inputInt++);
            Console.WriteLine("After Post-Increment :" + inputInt);
        }
    }
}
