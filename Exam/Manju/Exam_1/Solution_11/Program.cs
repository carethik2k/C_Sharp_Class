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
            // Why is all the logic in the Main() method. Should the logic be in a different class = -0.5 Mark

            //An exception is thrown if i simply hit 'Enter' instead of entering a number.
            //Always accept input and then try to do TryParse instead of parsing directly = -.5 Mark

            // logic to retry till the user enters 'quit' is missing =  -1 Mark

            // All of these operations are available as Array functions. There is no need to implement them.

            //Total = 8 Marks

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

