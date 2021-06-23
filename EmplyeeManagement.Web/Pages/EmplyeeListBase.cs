using EmployeeManagementModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmplyeeManagement.Web.Pages
{
    public class EmplyeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employee { get; set; }
        //protected override Task OnInitializedAsync()
        //{
        //    LoadEmpoyees();
        //    return base.OnInitializedAsync();
        //}
        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmpoyees);
           
        }
        private void LoadEmpoyees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee
            {
                Emplyeeid = 1,
                FirstName="Rashid",
                LastName="Malik",
                Email="itsmalikrashid@gmail.com",
                DateOfBirth = new DateTime(1992,10,1),
                Gender=Gender.Male,
                Departmentid =1,
                PhotoPath= "images/2021-03-19.jpg"
            };
            Employee e2 = new Employee
            {
                Emplyeeid = 2,
                FirstName = "Sara",
                LastName = "Khan",
                Email = "SKhan@yopmail.com",
                DateOfBirth = new DateTime(1995, 11, 10),
                Gender = Gender.Female,
                Departmentid = 2,
                PhotoPath = "images/sara.jpg"
            };
            Employee = new List<Employee> { e1 ,e2};
        }
    }
}
