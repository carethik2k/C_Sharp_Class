using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an color from Red/Green/Blue: ");
            string inputColor = Console.ReadLine();

            switch(inputColor)
            {
                case "Red":
                    Console.WriteLine("You selected Red");
                    break;

                case "Green":
                    Console.WriteLine("You selected Green");
                    break;

                case "Blue":
                    Console.WriteLine("You selected Blue");
                    break;

                default:
                    Console.WriteLine("Your selection didn't match the standard colors");
                    break;
            }
        }
    }
}
