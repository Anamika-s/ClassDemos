using System;

namespace EmployeeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Employee employee;
            ////employee = new Employee();
            //Employee employee1 = new Employee();
            //Employee employee2 = new Employee();
            //Employee employee3 = new Employee();
            //Console.WriteLine("Emp1:");
            //employee1.GetDetails();
            //employee1.DisplayDetails();
            //Console.WriteLine("Emp2:");
            //employee2.GetDetails();
            //employee2.DisplayDetails();
            //Console.WriteLine("Emp3:");
            //employee3.GetDetails();
            //employee3.DisplayDetails();
            Employee[] emps = new Employee[10];
            for(int i=0;i<2;i++)
            {
                Console.WriteLine("Enter Details for Employee No {0}", i + 1);
                emps[i] = new Employee();
                emps[i].GetDetails();
            }
            for (int i = 0; i <2; i++)
            {
                Console.WriteLine("Details for Employee No {0}", i + 1);
                
                emps[i].DisplayDetails();
            }
        }
    }
}
