using System;

namespace Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Color 1: ");
            var color1 = Console.ReadLine();

            //Console.WriteLine("Enter Color 2: ");
            string color2 = null;//Console.ReadLine();

            if (color1 == "RED" || color2.Length < 2)
                Console.WriteLine("2. " + color1 + " " + color2);
            if (!(color1 == "RED") || color2.Length < 2)
                Console.WriteLine("1. " + color1 + " " + color2);
            if (color1 == "RED" | color2.Length < 2)
                Console.WriteLine("2. " + color1 + " " + color2);

        }
    }
}
