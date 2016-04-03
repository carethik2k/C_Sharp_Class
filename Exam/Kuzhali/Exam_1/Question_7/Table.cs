using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    class Table
    {
        int n;
        public Table()
        {
            Console.Write("Please enter a number: ");
            n = UserInput.AcceptNumberInput();
        }
        public void Calculate()
        {
            int i;
            for (i = 1; i <= 10; ++i)
            {
                Console.WriteLine(n + " * " + i + " = " + n*i);
            }
            Console.ReadLine();
        }
    }
}

    

