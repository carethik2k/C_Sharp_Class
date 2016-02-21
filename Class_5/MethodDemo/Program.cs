using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            while (true)
            {
                Console.WriteLine();
                PrintString("Please enter a number: ");
                var number = AcceptNumberInput(); //Int32.Parse(Console.ReadLine());

                result += number;

                PrintString("Enter 0 to Quit.");
                var input = AcceptNumberInput(); //Int32.Parse(Console.ReadLine());
                if(input == 0)
                    break;
            }

            PrintString("Total Is: " + result,true);
            PrintString("Bye Bye !",true);
        }

        static int AcceptNumberInput()
        {
            int numInput = 0;
            while (true)
            {
                string strInput = Console.ReadLine();
                var isSuccess = Int32.TryParse(strInput, out numInput);
                if (isSuccess)
                    break;
                else
                {
                    Console.Write("\nValue entered is not a number. Please retry again: ");
                }
            }
            return numInput;
        }

        /// <summary>
        /// This method can be used to print in a single line or in multiple lines
        /// </summary>
        /// <param name="text">String to be printed to Console.</param>
        /// <param name="isWriteLine">Indicate whethere its same line or different lines</param>
        //Signature = PrintStringStringBool
        static void PrintString(string text, bool isWriteLine)
        {
            if (isWriteLine)
                Console.WriteLine(text);
            else
                Console.Write(text);
        }

        /// <summary>
        /// This method can be used to print in a single line
        /// </summary>
        /// <param name="text">String to be printed to Console.</param>
        //Signature = PrintStringString
        static void PrintString(string text)
        {
            Console.Write(text);
        }

        //Signature = PrintStringInt
        static void PrintString(int intqwe)
        {
            Console.Write(intqwe);
        }
    }
}
