using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration Only
            List<int> listInt = new List<int>();

            //Declaration & Assignment
            List<int> listInt2 = new List<int>() {1,2,3,4,5,6};

            listInt.Add(1);
            listInt.Add(1);
            listInt.Add(1);
            listInt.Add(1);

            listInt2.Add(1);
            listInt2.Add(1);
            listInt2.Add(1);
            listInt2.Add(1);

            Console.WriteLine(listInt[2]);
        }
    }
}
