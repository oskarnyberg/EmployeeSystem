using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EmployeeLibrary
{
    public class FileHandler
    {
        const string path = @"employees.csv";
        public static void AddUserToFile(Employee employee)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine($"{employee.EmployeeID},{employee.Password},{employee.Name},{employee.Adress},{employee.Admin}");
                    sw.Close();
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine($"{employee.EmployeeID},{employee.Password},{employee.Name},{employee.Adress},{employee.Admin}");
                    sw.Close();
                }
            }
        }

        public static void DisplayEmployees()
        {
            if (!File.Exists(path))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No employees, add emplyees first\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Console.WriteLine("ID - Password - Name - Adress - Admin");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("\n" + sr.ReadToEnd());
                    sr.Close();
                }
            }
        }
        public static void DeleteUserFromFile(string id)
        {
            string[] list = File.ReadAllLines(path);
            File.WriteAllText(path, string.Empty);
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (string s in list)
                {
                    if (!s.Contains(id))
                    {
                        sw.WriteLine(s);
                    }
                }
                sw.Close();
            }
        }

        public static bool VerifyAdmin(string id, string pw)
        {
            string[] list = File.ReadAllLines(path);
            bool check = false;
            foreach (string s in list)
            {
                if (s.Contains(id) && s.Contains(pw) && s.Contains("True"))
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }

        public static bool VerifyUser(string id, string pw)
        {
            string[] list = File.ReadAllLines(path);
            bool check = false;
            foreach (string s in list)
            {
                if (s.Contains(id) && s.Contains(pw))
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }
        public void UpdateUserInFile()
        {

        }
    }
}
