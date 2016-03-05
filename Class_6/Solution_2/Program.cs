using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Variable.Count++);
            //Console.WriteLine(Variable.Count++);
            //Console.WriteLine(Variable.Count++);

            //Variable objVar1 = new Variable();
            //objVar1.Test = "Hello";
            //Console.WriteLine(objVar1.Test);

            //Variable objVar2 = new Variable();
            //Console.WriteLine(objVar2.Test);

            //objVar2.DemoMethod();
            //objVar2.DemoMethod2();
            string shape;

            while (true)
            {

                Console.Write("Please enter the type of shape (Circle/Square/Quit): ");
                shape = Console.ReadLine().ToUpper();


                if (shape == "CIRCLE")
                {
                    Circle objcircle = new Circle();
                    objcircle.FindAreaOrDimension();
                }
                else if (shape == "QUIT")
                {
                    Console.WriteLine("Bye Bye");
                    break;
                }
                else
                    Console.WriteLine("Please enter valid input: ");
            }
        }
    }
}

