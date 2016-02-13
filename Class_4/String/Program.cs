using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string sampleString = string.Empty;
            sampleString = "Test" + "String    With  Spaces";
            Console.WriteLine(sampleString);
            Console.WriteLine("String Length :" + sampleString.Length);
            Console.WriteLine("SubString - Start Index 5: " + sampleString.Substring(5));
            var substring = sampleString.Substring(5, 3);
            Console.WriteLine("SubString - Start Index 5: " + substring);

            int a, b;
            a = 10;
            b = 10;

            if(a == b)
                Console.WriteLine("A and B are equal");

            string a1 = "test";
            string b1 = "test";

            if(a1.Equals(b1))
                Console.WriteLine("String A1 and B1 are equal");

            Console.Write("Enter a string to be split: ");
            string splitString = Console.ReadLine();
            var splits = splitString.Split(',');
            for (int i = 0; i < splits.Length; i++)
            {
                Console.WriteLine(splits[i]);
            }
        }
    }
}
