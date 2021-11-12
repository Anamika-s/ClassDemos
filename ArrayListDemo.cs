using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDemo
{
    class ArrayListDemo
    {
       static void Main()
        {
            ArrayList list = new ArrayList();
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
            //list.Add(1);  THIS IS THE PROBLEM AREA
            foreach(Employee employee in list)
            {
                employee.DisplayDetails(); 
            }
        }
    }
}
