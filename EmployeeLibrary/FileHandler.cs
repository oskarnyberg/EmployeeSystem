using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EmployeeLibrary
{
    public class FileHandler
    {
        const string path = @"EmployeeLibrary\employees.txt";
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

        public void DeleteUserFromFile()
        {

        }

        public void UpdateUserInFile()
        {

        }
    }
}
