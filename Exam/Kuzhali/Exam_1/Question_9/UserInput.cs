using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_9
{
    class UserInput
    {
        public static double AcceptNumberInput()
        {
            string strInput;
            double numInput = 0;
            while (true)
            {

                strInput = Console.ReadLine();
                var isSuccess = double.TryParse(strInput, out numInput);
                if (isSuccess)
                    break;
                else if (strInput.ToLower() == "quit")
                {
                    Console.WriteLine("Bye,Bye!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nPlease enter a valid input and try again !");
                    FindOutput.FindOutput1();
                    break;
                }
            }
            return numInput;
        }
    }
}
