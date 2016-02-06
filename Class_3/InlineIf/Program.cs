using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlineIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Color: ");
            var color = Console.ReadLine();

            //string result = string.Empty;
            //if (color == "RED")
            //    result = "R";
            //else
            //{
            //    result = "N";
            //}
            string result = (color == "RED") ? "R" : "N";
            Console.WriteLine("Color is " + result);
        }
    }
}
