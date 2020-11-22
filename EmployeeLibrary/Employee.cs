using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLibrary
{
    public class Employee
    {
        public Guid EmployeeID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public bool Admin { get; set; }

        public Employee(Guid employeeID, string password, string name, string adress, bool admin) 
        {
            EmployeeID = employeeID;
            Password = password;
            Name = name;
            Adress = adress;
            Admin = admin;
        }
    }
}
