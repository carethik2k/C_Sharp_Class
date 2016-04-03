using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Question_12
{
    class CheckinService
    {
        public static bool IsBookedIn { get; set; }
        private static int TotalSeat { get; set; } = 100;
        public static int num1,num2;


        public static void Run()
        {
            while (true)
            {
                string userInput = AcceptInput();
                switch (userInput)
                {
                    case "book":
                        Book();
                        break;
                    case "cancel":
                        Cancel();
                        break;
                    case "availability":
                        if (IsBookedIn)
                        {
                            TotalSeat = TotalSeat - num1;
                            Console.WriteLine(TotalSeat + " seats are available. ");
                        }
                        else
                        {
                            TotalSeat = TotalSeat + num2;
                            Console.WriteLine(TotalSeat + " tickets are available for the movie Titanic");
                        }
                        break;
                }
            }
        }

        private static void Cancel()
        {
            Console.Write("Please enter the number of tickets: ");
            num2 = AcceptNumberInput();
            if (IsBookedIn == true && num2 <= num1 )
            {
                Console.WriteLine(num2 + " tickets have been cancelled for the movie Titanic");
                IsBookedIn = false;
            }
            else
            {
                Console.WriteLine("Sorry you have to book before you  cancel or verify the number of tickets to cancel.");
            }
        }


        private static void Book()
        {
            Console.Write("Please enter the number of tickets: ");
            num1 = AcceptNumberInput();
            // if (IsBookedIn == false)
            // {
            if (TotalSeat >= num1)
            {
                Console.WriteLine(num1 + " tickets have been booked for the movie Titanic");
                IsBookedIn = true;
            }
            else
                Console.WriteLine("Booking failure!");
            //}

        }

        public static string AcceptInput()
        {
            int num;
            string input = string.Empty;
            while (true)
            {
                 Console.Write("Please enter what do you want to do: ");
                input = Console.ReadLine();
                if (input.ToLower() == "book" || input.ToLower() == "availability" || input.ToLower() == "cancel")
                 {
                        break;
                    }
                else if (input.ToLower() == "quit")
                    {
                        Console.WriteLine("Bye,Bye!");
                        break;
                    }
                    else
                        Console.WriteLine("Please enter a valid option.");
                }
                return input.ToLower();
            
        }

        public static int AcceptNumberInput()
        {
            int numInput = 0;
            while (true)
            {
                string strInput = Console.ReadLine();
                var isSuccess = int.TryParse(strInput, out numInput);
                if (isSuccess)
                    break;
                else
                {
                    Console.Write("\nValue entered is not a number. Please retry again: ");
                }
            }
            return numInput;
        }
    }
}
