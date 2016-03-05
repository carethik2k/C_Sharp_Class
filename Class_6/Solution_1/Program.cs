using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike objBike = new Bike();
            Console.WriteLine(objBike.DisplayBikeInfo);

            string tempString = objBike.GetBikeInfo();
            Console.WriteLine(tempString);
        }
    }
}
