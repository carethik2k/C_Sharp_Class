using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageNumber = 0;

            //Following statement with assign the value 10 to ageNumber
            ageNumber = 10;

            //Following statement if ageNumber "is equal to" 10;
            Console.WriteLine("Is ageNumber equal to 10 ? " + (ageNumber == 10));

            float a = 1.02f;
            Console.WriteLine("Value of f = " + a);

            //Type Casting
            // Int the following statement ,a is converted to an integer, so the decimal is dropped off.

            int i = (int)a;
            Console.WriteLine("Typecasting fload to int : "+i);

            //Other ways of doing this
            Console.WriteLine("Typecasting fload to int : " + Convert.ToInt32(a));
        }
    }
}
