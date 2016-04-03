using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Solution_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> userList = new List<int>();
            while(true)
            { 
            Console.Write("Please enter the list of numbers (num/quit) : ");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                    break;
            else
                {
                    userList.Add(Convert.ToInt32(input));
                }
            }
            Console.WriteLine("Sorted list of numbers : ");
            userList.Sort();
            foreach (var input in userList)
            {
                Console.WriteLine(input);
            }
        }
    }
}










