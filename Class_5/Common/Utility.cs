using System;

namespace Common
{
    public class Utility
    {
        public static int AcceptNumberInput()
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
    }
}
