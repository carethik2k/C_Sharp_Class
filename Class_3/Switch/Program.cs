using System;
using System.Collections;
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
            Console.WriteLine("Enter a Color: ");
            var color = Console.ReadLine();

            switch (color)
            {
                case "DARK RED":
                case "LIGHT RED":
                case "RED":
                    Console.WriteLine("Blood is Red");
                    break;
                case "DARK GREEN":
                case "LIGHT GREEN":
                case "GREEN":
                    Console.WriteLine("Leaf is Green");
                    break;
                default:
                    Console.WriteLine("No Match");
                    break;
            }

            Console.WriteLine("Enter a Number: ");
            int number = Int32.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("1st is best !");
                    break;

                default:
                    Console.WriteLine("Rest are forgotten !");
                    break;
            }
        }
    }
}
