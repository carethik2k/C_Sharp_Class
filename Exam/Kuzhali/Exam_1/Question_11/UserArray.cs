using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Question_11
{
    class UserArray
    {
        public static string type;

        public static void UserList1()
        {
            Console.Write("Please enter the number of elements in the array: ");
            var arraySize = Int32.Parse(Console.ReadLine());
            int[] userArray = new int[arraySize];
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.Write("Enter element  " + (i + 1) + " : " + " ");
                userArray[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Write("Enter operation: " + type);
            type = Console.ReadLine().ToLower();
            if ((type == "min") || (type == "max") || (type == "count") || (type == "sum") || (type == "avg"))
            {
                if (type == "min")
                Console.WriteLine("Minimum value in the array: "+ userArray.Min());
            else if (type == "max")
                Console.WriteLine("Maximum value in the array: "+ userArray.Max());
            else if (type == "count")
                Console.WriteLine("Count of the array: " + userArray.Count());
            else if (type == "sum")
                Console.WriteLine("Sum of the array: "+ userArray.Sum());
            else if (type == "avg")
                Console.WriteLine("Average of the array: "+ userArray.Average());
                else if (type == "quit")
                Console.WriteLine("Bye,Bye!");
            else
                Console.WriteLine("Please enter the valid type");
        }
        }
    }
}
