using EmployeeLibrary;
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
            Console.WriteLine("Enter first 4 chars in ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string pw = Console.ReadLine();
            bool verify = FileHandler.VerifyAdmin(id, pw);
            if(verify == true)
            {
                Console.Clear();
                Console.WriteLine("Successful login");
                MainMenu();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong id, password, not admin or user don't exist!\n");
                Console.ForegroundColor = ConsoleColor.White;
                StartMenu();
            }
        }
        public void MainMenu()
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
            Guid employeeID = Guid.NewGuid();
            Console.Write("New ID is: ");
            Console.WriteLine(employeeID);
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter full name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter adress: ");
            string adress = Console.ReadLine();
            bool check = false;
            bool admin;
            do
            {
                Console.WriteLine("Is new user admin? Enter Y for yes, N for no");
                var option = Console.ReadLine();
                if (option == "Y")
                {
                    admin = true;
                    check = true;
                }
                else if (option == "N")
                {
                    admin = false;
                    check = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    admin = false;
                }
            } while (check == false);
            var employee = new Employee(employeeID, password, name, adress, admin);
            Console.Clear();
            Console.WriteLine(employee.EmployeeID);
            Console.WriteLine(employee.Password);
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Adress);
            Console.WriteLine(employee.Admin);
            FileHandler.AddUserToFile(employee);
        }

        void DeleteEmployee()
        {
            FileHandler.DisplayEmployees();
            Console.WriteLine("Enter the first 4 chars in ID ");
            string id = Console.ReadLine();
            FileHandler.DeleteUserFromFile(id);
        }
    }
}
