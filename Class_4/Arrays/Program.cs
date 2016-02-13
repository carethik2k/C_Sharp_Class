using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sample initialization of string
            string test = "";

            // Number of elements declared is used as array size
            int[] ageArray = new[] {10, 11, 12, 13, 14, 12, 12, 12, 12, 12};
            ageArray[1] = ageArray[1] + 20;

            //Sets the elements to default value
            Array.Clear(ageArray, 0,2);

            int[] newArray = new int[ageArray.Length];
            Array.Copy(ageArray, newArray, 5);

            Console.WriteLine(ageArray.Length);

            //Explicit Size Declaration
            //int[] ageArray2 = new int[2];
            //ageArray2 = new[] {1, 2, 4};

            //Common Library
            //Console.BackgroundColor = ConsoleColor.Blue;
            //var x = Console.ReadLine();
            //Console.WriteLine(ageArray[2]);

        }
    }
}
