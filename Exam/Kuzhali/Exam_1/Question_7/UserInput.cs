using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    class UserInput
    {
        public static int AcceptNumberInput()
        {
            int numInput;
            while (true)
            {
                var strInput = Console.ReadLine();
                var isSuccess = int.TryParse(strInput, out numInput);
                if (isSuccess)
                    break;
                else if (strInput == "quit")
                {
                    Console.WriteLine("Bye,Bye!");
                    Console.ReadLine();
                    }
            Console.Write("\nValue entered is not a number. Please retry again: ");
                }
                
            return numInput;
        }
    }
}

