using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> userList = new List<int>();

            while (true)
            {
                Console.Write("Enter as number. Q to exit :");
                var input = Console.ReadLine();
                if (input == "Q")
                    break;
                else
                {
                    userList.Add(Convert.ToInt32(input));
                }
            }

            userList.Insert(1,100);
            userList.Remove(100);
            userList.RemoveAt(1);

            
            Console.WriteLine("Printing List.");
            for (int i = 0; i < userList.Count; i++)
            {
                Console.WriteLine(userList[i]);
            }

            userList.Clear();
        }
    }
}
