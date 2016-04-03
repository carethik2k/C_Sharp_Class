using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Solution_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //All of the logic is in the same class = -.5 Mark

            //Looping is incorrect. If i enter a string, it should keep asking options till i quit once. 
            // Right now it performs for example 'Length' and asks for next string. = -1 Mark
            
            // a = Char.Parse(Console.ReadLine()); This line results in an exception if i simply hit 'Enter' instead of entering a character.
            //Always accept input and then try to do TryParse instead of parsing directly = -.5 Mark

            // Total = 8 Marks

            string strInput,strInput1;
            char a;
            while (true)
            {
                Console.Write("Please enter a string (string/quit) : ");
                strInput = Console.ReadLine();
                if (strInput.ToLower() != "quit")
                {
                    while (true)
                    {
                        Console.Write("Action (length/reverse/count) : ");
                        strInput1 = Console.ReadLine();
                        if (strInput1.ToLower() == "length" || strInput1.ToLower() == "reverse" ||
                            strInput1.ToLower() == "count")
                            break;
                        else
                        {
                            Console.WriteLine("Please enter a valid option.");
                        }
                    }
                    if (strInput1.ToLower() == "length")
                        Console.WriteLine("Length of the entire string is : " + strInput.Length);
                    else if (strInput1.ToLower() == "count")
                    {
                        Console.Write("The character that you want to count : ");
                        a = Char.Parse(Console.ReadLine());
                        int count = 0;
                        for (int i = 0; i < strInput.Length; i++)
                        {
                            if (strInput[i] == a)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine("The character '" + a + "' occurs a total of " + count + " time");
                    }
                    else if (strInput1.ToLower() == "reverse")
                    {
                        char[] toReverse = strInput.ToCharArray();
                        Array.Reverse(toReverse);
                        String strReverse = new String(toReverse);
                        Console.WriteLine("String in reverse : " + strReverse);
                    }
                }
                else
                {
                    Console.WriteLine("Thank you. Bye! Bye!");
                    break;
                }
            }
        }
    }
}



