using System;

namespace Solution_3
{
    public class LoginService
    {
        public static bool IsUserLoggedIn { get; set; }
        public static int UserCount { get; set; }

        public static void Run()
        {
            while (true)
            {
                string userInput = AcceptInput();
                switch (userInput)
                {
                    case "login":
                        Login();
                        break;
                    case "logoff":
                        LogOff();
                        break;
                    case "quit":
                        if(IsUserLoggedIn)
                            Console.WriteLine("Sorry you have to logoff before you can Quit.");
                        else
                        {
                            Console.WriteLine("Thanks. You are now logged out.");
                        }
                        break;
                }

                if (userInput == "quit" && !IsUserLoggedIn)
                {
                    Console.WriteLine(string.Format("Thank you ! A total of {0} users logged in and logged off !",UserCount));
                    break;
                }
            }
        }
        
        private static void LogOff()
        {
            if (IsUserLoggedIn == true)
            {
                Console.WriteLine("Thanks. You are now logged out.");
                IsUserLoggedIn = false;
            }
            else
            {
                Console.WriteLine("Hi. You have not logged in to the student network.");
            }
        }

        private static void Login()
        {
            if (IsUserLoggedIn == false)
            {
                Console.WriteLine("Hi. You are now logged in to the student network.");
                IsUserLoggedIn = true;
                UserCount++;
            }
            else
            {
                Console.WriteLine("Hi. You are already logged on to the the student network.");
            }
        }

        private static string AcceptInput()
        {
            string input = string.Empty;
            while (true)
            {
                Console.Write("Please enter an action (Login/Logoff/Quit) :");
                input = Console.ReadLine();

                if (input.ToLower() == "login" || input.ToLower() == "logoff" || input.ToLower() == "quit")
                break;
                else
                    Console.WriteLine("Please enter a valid option.");
            }

            return input.ToLower();
        }
    }
}