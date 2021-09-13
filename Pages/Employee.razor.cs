using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LatihanBlazor.Models;


namespace LatihanBlazor.Pages
{
    public partial class EmployeePage
    {
           
            public IEnumerable<Employee> Employees { get; set; }

            protected override Task OnInitializedAsync()
            {
                LoadEmployees();
                return base.OnInitializedAsync();
            }

            private void LoadEmployees(){
                Employee e1 = new Employee{
                    EmployeeId = 1,
                    FirstName ="Alex Septimand",
                    LastName = "Gulo",
                    Email="alexseptimand@gmail.com",
                    DateOfBirth = new DateTime(2001,10,18),
                    Gender = Gender.Male,
                    Department = new Department{DepartmentId=1, DepartmentName="SI"},
                    PhotoPath ="images/alex.jpg"
                };
                   Employee e2 = new Employee{
                    EmployeeId = 2,
                    FirstName ="Gabriel",
                    LastName = "Manaor",
                    Email="gabriel@gmail.com",
                    DateOfBirth = new DateTime(2001,8,27),
                    Gender = Gender.Male,
                    Department = new Department{DepartmentId=2, DepartmentName="TI"},
                    PhotoPath ="images/gabriel.jpg"
                };
                   Employee e3 = new Employee{
                    EmployeeId = 1,
                    FirstName ="Herling",
                    LastName = "kalangit",
                    Email="herling@gmail.com",
                    DateOfBirth = new DateTime(2001,9,20),
                    Gender = Gender.Male,
                    Department = new Department{DepartmentId=1, DepartmentName="SI"},
                    PhotoPath ="images/herling.jpg"
                };

                Employee e4 = new Employee{
                    EmployeeId = 4,
                    FirstName ="Ferry",
                    LastName = "Ferry",
                    Email="ferry@gmail.com",
                    DateOfBirth = new DateTime(2001,8,24),
                    Gender = Gender.Male,
                    Department = new Department{DepartmentId=1, DepartmentName="SI"},
                    PhotoPath ="images/ferry.jpg"
                };

                Employees = new List<Employee> {e1,e2,e3, e4};
            
        }
    }
}