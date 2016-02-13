using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the Array: ");
            var arraySize = Int32.Parse(Console.ReadLine());

            int[] userArray = new int[arraySize];
            Console.WriteLine("Accepting inputs for the Array:");
            for (int i = 0; i < userArray.Length; i++)
            {
                userArray[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sorting the Array:");
            Array.Sort(userArray);

            Console.WriteLine("Printing the Array:");
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine("Value of Array at position " + i + ":" + userArray[i]);
            }

            Console.WriteLine("Printing the Array in Reverse:");
            for (int i = userArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine("Value of Array at position " + i + ":" + userArray[i]);
            }

            Console.WriteLine("Index of 10 :" + Array.IndexOf(userArray,10));

            Console.ReadLine();

        }
    }
}
