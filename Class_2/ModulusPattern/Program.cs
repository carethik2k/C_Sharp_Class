using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulusPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number pattern that has to be printed: ");
            string input = Console.ReadLine();

            //Typecast to int
            int inputInt = 0;
            bool parseResult = Int32.TryParse(input, out inputInt);

            for(int i = 1; i <= 20; i++)
            {
                if (i % inputInt == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
