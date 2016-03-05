using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution2;

namespace Solution_2
{
    class Circle
    {
        private double radius, area;
        private readonly string type;
        public Circle()
        {
            while (true)
            {
                Console.Write("Type of value being entered (Dimension/Area): ");
                type = Console.ReadLine().ToUpper();

                if (type == "AREA" || type == "DIMENSION")
                    break;
                else
                    Console.WriteLine("Enter a valid input");
            }

            if (type == "DIMENSION")
            {
                Console.Write("Please enter the radius of the Circle: ");
                radius = UserInput.AcceptNumberInput();
            }
            else if (type == "AREA")
            {
                Console.Write("Please enter the area of Circle: ");
                area = UserInput.AcceptNumberInput();
            }
        }
        public void FindAreaOrDimension()
        {
            if (type == "DIMENSION")
            {
                double area = Math.PI * (radius * radius);
                Console.WriteLine("Area of the circle = " + area);
            }
            else
            {
                double squareroot = Math.Round(Math.Sqrt(area / Math.PI));
                Console.WriteLine("radius of the circle: " + squareroot);
            }
        }
    }
}
