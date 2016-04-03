using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Solution_12
{
    public class Booking
    {
        public static bool IsUserBookedIn { get; set; }
        public static int UserCount { get; set; }
        public static int Result { get; set; }
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
                        if (IsUserBookedIn)
                            Console.WriteLine(UserCount + " tickets are available for the movie \"Titanic\".");
                        else
                        {
                            Result += UserCount;
                            Console.WriteLine(Result + " tickets are available for the movie \"Titanic\".");
                        }
                        break;
                }
                if (userInput == "quit")
                {
                    Console.WriteLine("Thank you. Bye! Bye!");
                    break;
                }
            }
        }
        private static void Cancel()
        {
            if (IsUserBookedIn == true)
            {
                Console.Write("Please enter the number of tickets:");
                Result = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Result + " tickets have been cancelled for the movie \"Titanic\".");
                IsUserBookedIn = false;
            }
            else
            {
                Console.WriteLine("Hi. You haven't booked the tickets.");
            }
        }
        private static void Book()
        {
            if (IsUserBookedIn == false)
            {
                Console.Write("Please enter the number of tickets:");
                UserCount = Convert.ToInt32(Console.ReadLine());
                IsUserBookedIn = true;
                Console.WriteLine(UserCount + " tickets have been booked for the movie \"Titanic\".");
                UserCount = 100 - UserCount;
            }
            else
            {
                Console.WriteLine("Sorry,there is no availability of tickets for the movie \"Titanic\".");
            }
        }
        private static string AcceptInput()
        {
            string input = string.Empty;

            while (true)
            {
                Console.Write("Please enter what you want to do? (Book/Cancel/Availability/Quit) :");
                input = Console.ReadLine();

                if (input.ToLower() == "book" || input.ToLower() == "cancel" || input.ToLower() == "availability")
                    break;
                else if (input.ToLower() == "quit")
                    break;
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                }
            }
            return input.ToLower();
        }
    }
}
   

