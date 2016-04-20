using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);

            string[] strArray = new string[] {"Hi","How","Are","You"};

            //Simple for loop
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }

            //Simple foreach to iterate int List
            string strTemp = string.Empty;
            foreach (int item in intList)
            {
                strTemp += item + ",";
            }
            Console.WriteLine(strTemp.Substring(0,strTemp.Length-1)+".");

            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}

