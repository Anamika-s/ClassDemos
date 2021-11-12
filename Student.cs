using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDemo
{
    class Student
    {
        int rn;
        string name;
        int marks;
        //public static string batchCode="B001";
        static string batchCode;
        public const string schoolName ="CTS";
        public static void BatchDetails()
        {
            batchCode = "B001";
             
            Console.WriteLine("Batch Code is " + batchCode);
        }
        public void GetDetails()
        {

            Console.WriteLine("Enter rn");
            rn = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            //Console.WriteLine("Enter batchCode");
            //batchCode = Console.ReadLine();
            //Console.WriteLine("Enter schoolName");
            //schoolName = Console.ReadLine();
            Console.WriteLine("Enter marks");
            marks = Convert.ToInt16(Console.ReadLine());
        }
        public void DisplayDetails()

        {
            Console.WriteLine("rn is " + rn);
            Console.WriteLine("Name is " + name);
            //Console.WriteLine("schoolName is " + schoolName);
            //Console.WriteLine("batchCode is " + batchCode);
            Console.WriteLine("marks is " + marks);
        }
    }
}
