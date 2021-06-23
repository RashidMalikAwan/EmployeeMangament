using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementModels
{
    public class Employee
    {
        public int Emplyeeid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int Departmentid { get; set; }
        public string PhotoPath { get; set; }

    }
}
