using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    static class Temple
    {
        //Static Field
        public static string name = "Hindi Temple of Omaha";

        //Static Property / Static Method 
    }

    class Zoo
    {
        public static string name = "Henry Doorly Zoo";
        public string Hours = "9 AM to 9 PM";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Temple.name = "Test";
            Console.WriteLine(Temple.name);

            Console.WriteLine(Zoo.name);

            var objZoo = new Zoo();
            Console.WriteLine(objZoo.Hours);

        }
    }
}
