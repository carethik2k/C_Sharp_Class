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
            //Why is all the logic in the Main() method. Should the logic be in a different class = -0.5 Mark

            //Questions says accept a comma seperated string. You are accepting one at a time = -2 Marks

            //An exception is thrown if i simply hit 'Enter' instead of entering a number.
            //Always accept input and then try to do TryParse instead of parsing directly = -.5 Mark

            //Output not in comma seperated format = -1 Mark

            //Total = 6 Marks

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










