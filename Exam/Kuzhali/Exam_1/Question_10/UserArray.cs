using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_10
{
    class UserArray
    {
        public static string input;
        public static void UserArray1()
        {
            List<int> userList = new List<int>();
            Console.WriteLine("Please enter the list of numbers :");
            while (true)
            {
                input=Console.ReadLine();
               // input = AcceptNumberInput();
                 if (input.ToLower() == "quit")
                  break;
                  else
                 {
                // var inputsplit = input.Split(',');
                  userList.Add(Int32.Parse(input));
                
                 }
                }
                userList.Sort();
            
            Console.Write("Sorted list of numbers: ");
            for (int i = 0; i < userList.Count; i++)
            {
                Console.Write(userList[i] + ", ");
            }
            Console.ReadLine();
        }

     /*   public static int AcceptNumberInput()
        {
            int numInput = 0;
            while (true)
            {
                var strInput = Console.ReadLine();
                var isSuccess = int.TryParse(strInput, out numInput);
                if (isSuccess)
                {
                    break;
                }
                else if (strInput.ToLower() == "quit")

                    break;

                else
                {
                    Console.Write("\nValue entered is not a number. Please retry again: ");
            }
            }
            return numInput;
        }*/
    }
}
