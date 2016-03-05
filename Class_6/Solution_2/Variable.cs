using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_2
{
    class Variable
    {
        //Global/Static Variable
        public static int Count = 10;

        //Instance/Class Variable
        public string Test = "Hi";

        public void DemoMethod()
        {
            string Test = "Hello";

            if (true)
            {
                string localVar = "Testing...";
                Console.WriteLine(localVar);
            }

            //Will generate error
            //Console.WriteLine(localVar);
        }

        public void DemoMethod2()
        {
            Console.WriteLine(Test);
        }
    }
}
