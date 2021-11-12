using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDemo
{
    class Employee
    {
        int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        string department;
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        string manager;
        public string Manager
        {
            get
            {
                return manager;
            }
            set
            {
                manager = value;
            }
        }
        int salary;
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public void GetDetails()
        {
            Console.WriteLine("Enter ID");
            id = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Department");
            department = Console.ReadLine();
            Console.WriteLine("Enter Manager Name");
            manager = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            salary = Convert.ToInt16(Console.ReadLine());
        }
        public void DisplayDetails()

        {
            Console.WriteLine("ID is " + id);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Departmant is " + department);
            Console.WriteLine("Manager is " + manager);
            Console.WriteLine("Salary is " + salary);
        }



    }
}
