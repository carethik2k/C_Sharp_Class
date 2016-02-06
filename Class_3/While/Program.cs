using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter value 10 to see the difference
            Console.WriteLine("Enter a Number: ");
            int number = Int32.Parse(Console.ReadLine());

            Console.WriteLine("While Loop");
            while (number < 10)
            {
                if(number > 5)
                    break;
                Console.WriteLine(number);
                number++;
            }

            Console.WriteLine("Enter a Number: ");
            number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Do While Loop");
            do
            {
                Console.WriteLine(number);
                number++;
            } while (number < 10);
        }
    }
}
