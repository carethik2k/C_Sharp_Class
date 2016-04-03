using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question_8
{
    public class Operation
    {
        // Why are you using static methods and static variables ?
        // Not a big deal, but you should've use static unless there is a reason.
        public static string input { get; set; }
        public static string action { get; set; }
        public static string s1 { get; set; }

        public static void Operation1()
        {
            while (true)
            {
                Console.Write("Please enter a string: ");
                input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("Bye,Bye!");
                    break;
                }
                else
                {
                    // I haven't asked in the question, but usually its a good practice to list the possible actions, so that the user will know them.
                    Console.Write("Action : ");
                    action = Console.ReadLine().ToUpper();
                    if ((action == "REVERSE") || (action == "LENGTH") || (action == "COUNTCHAR"))
                        Findanswer();
                    else
                        Console.WriteLine("Please enter a valid action");
                }
            }
        }

        public static void Findanswer()
        {
            if (action == "LENGTH")
                Console.WriteLine("Length of the entire string is " + (input.Length));
            else if (action == "REVERSE")
            {
                char[] rev = input.ToCharArray();
                Array.Reverse(rev);
                string revs = new string(rev);
                Console.WriteLine(revs);
            }
            else if (action == "COUNTCHAR")
            {
                Console.WriteLine("Enter the character that you want to count: ");
                s1 = Console.ReadLine();
                Console.WriteLine("The character " + s1 + " occurs a total of " +
                                  TextTool.CountStringOccurrences(input, s1) + " time.");
            }
        }
    }
}


