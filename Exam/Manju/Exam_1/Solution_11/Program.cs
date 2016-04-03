using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_11
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter the number of elements in the array : ");
                var arraySize = Int32.Parse(Console.ReadLine());
                int[] userArray = new int[arraySize];
                for (int i = 0; i < userArray.Length; i++)
                {
                    Console.Write("Enter element " + i + ": ");
                    userArray[i] = Int32.Parse(Console.ReadLine());
                }
                Console.Write("Enter operation (min/max/count/sum/avg/quit) : ");
                string strInput = Console.ReadLine();
                if (strInput.ToLower() == "min")
                {
                    int min = userArray[0];
                    for (int i = 0; i < userArray.Length; i++)
                    {
                        if (min > userArray[i])
                            min = userArray[i];
                    }
                    Console.WriteLine("Minimum value in the array : " + min);
                }
                else if (strInput.ToLower() == "max")
                {
                    int max = userArray[0];
                    for (int i = 0; i < userArray.Length; i++)
                    {
                        if (max < userArray[i])
                            max = userArray[i];
                    }
                    Console.WriteLine("Maximum value in the array : " + max);
                }
                else if (strInput.ToLower() == "count")
                {
                    int count = userArray[0];
                    count = userArray.Length;
                    Console.WriteLine("Total number of values in the array : " + count);
                }
                else if (strInput.ToLower() == "sum")
                {
                    int sum = userArray[0];
                    sum = userArray.Sum();
                    Console.WriteLine("Sum of values of an array : " + sum);
                }
                else if (strInput.ToLower() == "avg")
                {
                    double avg = userArray[0];
                    avg = userArray.Average();
                    Console.WriteLine("Average values of an array : " + avg);
                }
                else if (strInput.ToLower() == "quit")
                {
                    Console.WriteLine("Thank you. Bye! Bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                }
            }
        }
    }
}

