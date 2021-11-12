using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace EmployeeDemo
{
    class InitailiazeListByProperties
    {
        static void Main()
        {
            List<Employee> list = new List<Employee>();
            // Initialize Object
            // Object Initialzer
            Employee emp1 = new Employee()
            {
                Id = 1,
                Name = "Ajay",
                Department = "HR"
            ,
                Manager = "Deepak",
                Salary = 10090
            };
            // Collection Initializer
            List<Employee> employeelist = new List<Employee>()
            {
                new Employee() { Id=1, Name="Manoj", Manager="D", Department="HR", Salary= 90099},

                new Employee() { Id = 1, Name = "Manoj", Manager = "D", Department = "HR", Salary = 90099 },
                new Employee() { Id = 1, Name = "Manoj", Manager = "D", Department = "HR", Salary = 90099 },
                new Employee() { Id = 1, Name = "Manoj", Manager = "D", Department = "HR", Salary = 90099 },
                new Employee() { Id = 1, Name = "Manoj", Manager = "D", Department = "HR", Salary = 90099 },
                new Employee() { Id = 1, Name = "Manoj", Manager = "D", Department = "HR", Salary = 90099 },

                };

            //List<Employee> employeelist = new List<Employee>();
            //Employee emp1 = new Employee() { Id = 1, Name = "Manoj", Manager = "D", Department = "HR", Salary = 90099 };
            //employeelist.Add(emp1);
            //Employee emp2 = new Employee() { Id = 1, Name = "Manoj", Manager = "D", Department = "HR", Salary = 90099 };
            //employeelist.Add(emp2);

            //}
            //    {
            //        new Employee() 
            //        new Employee() { Id = 1, Name = "Manoj", Manager = "D", Department = "HR", Salary = 90099 },
            //        new Employee() { Id = 1, Name = "Manoj", Manager = "D", Department = "HR", Salary = 90099 },
            //        new Employee() { Id = 1, Name = "Manoj", Manager = "D", Department = "HR", Salary = 90099 },
            //        new Employee() { Id = 1, Name = "Manoj", Manager = "D", Department = "HR", Salary = 90099 },
            //        new Employee() { Id = 1, Name = "Manoj", Manager = "D", Department = "HR", Salary = 90099 },

            //        };

            foreach (Employee employee in employeelist)
            {
                employee.DisplayDetails();
            }
                }
    }
}
