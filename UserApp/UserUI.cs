using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserApp
{
    public class UserUI
    {
        public void StartMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Employee system, user portal");
                Console.WriteLine("Choose what to do: ");
                Console.WriteLine("1: Log in");
                Console.WriteLine("2: Exit app");

                switch (Console.ReadLine())
                {
                    case "1":
                        Login();
                        break;
                    case "2":
                        Console.WriteLine("Ending program...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Must be an valid menu selection!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }
        void Login()
        {
            Console.WriteLine("Enter valid user credentials to start using.");
            Console.WriteLine("Enter first 4 chars in ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string pw = Console.ReadLine();
            bool verify = FileHandler.VerifyUser(id, pw);
            if (verify == true)
            {
                Console.Clear();
                Console.WriteLine("Successful login");
                MainMenu();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong id, password, or user don't exist!\n");
                Console.ForegroundColor = ConsoleColor.White;
                StartMenu();
            }
        }
        void MainMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Employee user interface: ");
                Console.WriteLine("Choose what to do: ");
                Console.WriteLine("1: Update my information");
                Console.WriteLine("2. Exit app");

                switch (Console.ReadLine())
                {
                    case "1":
                        UpdateUserInformation();
                        break;
                    case "2":
                        Console.WriteLine("Ending program...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Must be an valid menu selection!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }

        void UpdateUserInformation()
        {
            Console.WriteLine("Enter your first 4 in ID");
            string id = Console.ReadLine();
            FileHandler.UpdateUserInFile(id);
        }
    }
}
