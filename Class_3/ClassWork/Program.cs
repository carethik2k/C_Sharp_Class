using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            //while (true)
            //{
            //    Console.Write("Enter a number : ");
            //    var input = Int32.Parse(Console.ReadLine());
            //    Console.Write("Do you want to continue Y/N ? ");
            //    var decision = Console.ReadLine().ToUpper() == "Y";
            //    result = result + input;
            //    if (!decision)
            //        break;
            //}

            for (int i = 0; true; i++)
            {
                Console.Write("Enter a number : ");
                var input = Int32.Parse(Console.ReadLine());
                Console.Write("Do you want to continue Y/N ? ");
                var decision = Console.ReadLine().ToUpper() == "Y";
                result += input;
                if (!decision)
                    break;
            }

            Console.WriteLine("Total Sum : " + result);
        }
    }
}
