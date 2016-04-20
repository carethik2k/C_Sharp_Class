using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValueAndReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            PassByValue(a);
            Console.WriteLine("a outside method = {0}", a);

            int[] abc = new[] {1, 2};
            PassByReference(abc);
            Console.WriteLine("abc[0] outside method = {0}", abc[0]);
        }

        public static void PassByValue(int a)
        {
            a++;
            Console.WriteLine("a inside method = {0}", a);
        }

        public static void PassByReference(int[] abc)
        {
            abc[0] = 5;
            Console.WriteLine("abc[0] inside method = {0}", abc[0]);
        }
    }
}

