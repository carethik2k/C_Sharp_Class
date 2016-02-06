using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Break");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\nContinue");
            for (int i = 0; i < 10; i++)
            {
                if (i >= 5 && i <= 8)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
