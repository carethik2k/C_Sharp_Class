using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
    public class UserInput
    {
        public static double AcceptNumberInput()
        {
            double numInput = 0;
            while (true)
            {
                string strInput = Console.ReadLine();
                var isSuccess = double.TryParse(strInput, out numInput);
                if (isSuccess)
                    break;
                else
                {
                    Console.Write("\nValue entered is not a number. Please retry again: ");
                }
            }
            return numInput;
        }

    }
}