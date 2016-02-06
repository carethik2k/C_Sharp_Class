using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Color: ");
            var color = Console.ReadLine();

            if (color == "RED")
            {
                Console.WriteLine("RED");
                Console.WriteLine("ONLY IF RED");
            }
            if (color == "GREEN")
                Console.WriteLine("GREEN");

            Console.ReadLine();
        }
    }
}
