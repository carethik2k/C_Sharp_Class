using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus
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

            Console.WriteLine("Modulus of " + inputInt + " by 5, i.e. " + inputInt + " % 5 = " + inputInt % 5);
        }
    }
}
