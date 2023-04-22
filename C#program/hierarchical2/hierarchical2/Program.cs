using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical2
{
    class person
    {
        public string name;
        public string address;
    }
    class student : person
    {
        public int rno;
        public int marks;
    }
    class employee : person
    {
        public int salary;
        public string designation;
    }
    class program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.name = "tanu";
            s.address = "kuhi";
            s.rno = 19;
            s.marks = 350;
            Console.WriteLine("student details");
            Console.WriteLine("name" + s.name);
            Console.WriteLine("address" + s.address);
            Console.WriteLine("rno" + s.rno);
            Console.WriteLine("marks" + s.marks);

            employee emp = new employee();
            emp.name = "ravinash";
            emp.address = "nagpur";
            emp.salary = 70000;
            emp.designation = "manager";
            Console.WriteLine("emp details");
            Console.WriteLine("name" + emp.name);
            Console.WriteLine("address" + emp.address);
            Console.WriteLine("salary" + emp.salary);
            Console.WriteLine("designation" +emp.designation);
            Console.ReadLine();
        }
    }
}

              

  

