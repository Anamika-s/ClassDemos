using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDemo
{
    class GenericEmployee
    { 
        static void Main()
        {
            List<Employee> list = new List<Employee>();
            char ch = 'y';
            while (ch == 'y')
            {
                Employee emp = new Employee();
                emp.GetDetails();
                emp.DisplayDetails();
                list.Add(emp);
                Console.WriteLine("COntinue ?");
                ch = Convert.ToChar(Console.ReadLine());
            }
             // list.Add(1); //THIS IS NOT ALLOWED 
            foreach (Employee employee in list)
            {
                employee.DisplayDetails();
            }
        }
    }
}
