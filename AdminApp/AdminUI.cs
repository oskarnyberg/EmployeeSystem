using System;
using System.Collections.Generic;
using System.Text;

namespace AdminApp
{
    public class AdminUI
    {
        public void StartMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Employee system, admin portal");
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
            Console.WriteLine("Enter employee ID: ");
            Console.ReadLine();
            Console.WriteLine("Enter password: ");
            Console.ReadLine();
            MainMenu();
        }
        void MainMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Admin user interface: ");
                Console.WriteLine("Choose what to do: ");
                Console.WriteLine("1: Create new employee");
                Console.WriteLine("2: Delete existing employee");
                Console.WriteLine("3. Exit app");

                switch (Console.ReadLine())
                {
                    case "1":
                        CreateEmployee();
                        break;
                    case "2":
                        DeleteEmployee();
                        break;
                    case "3":
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

        void CreateEmployee()
        {

        }

        void DeleteEmployee()
        {

        }
    }
}
