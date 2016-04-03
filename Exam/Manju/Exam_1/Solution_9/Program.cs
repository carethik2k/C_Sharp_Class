using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter the number (number/quit) : ");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("Thank you. Bye! Bye!");
                    break;
                }
                else
                {
                    int inputInt = 0;
                    bool parseResult = Int32.TryParse(input, out inputInt);
                    if (!parseResult)
                        Console.WriteLine("Please enter a valid option.");
                    else
                    {
                        input = (inputInt%2 == 0) ? "Even" : "Odd";
                        Console.WriteLine("The number entered '" + inputInt + "' is " + input);
                    }
                }
            }
        }
    }
}
                
                 