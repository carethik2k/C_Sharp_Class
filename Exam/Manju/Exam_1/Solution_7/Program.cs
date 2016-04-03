using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Why is all the logic in the Main() method. Should the logic be in a different class = -0.5 Mark

            // Total = 9.5 Marks

            while (true)
            {
                Console.Write("Please enter a number (number/quit) : ");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("Thank you. Bye! Bye!");
                    break;
                }
                else 
                {
                    int inputInt = 0;
                    int i;
                    bool parseResult = Int32.TryParse(input, out inputInt);
                    if (!parseResult)
                        Console.WriteLine("Please enter a valid option.");
                    else
                    {
                        for (i = 1; i <= 10; ++i)
                        {
                            Console.WriteLine(inputInt + " * " + i + " = " + inputInt*i);
                        }
                    }
                }
            }
        }
    }
}
