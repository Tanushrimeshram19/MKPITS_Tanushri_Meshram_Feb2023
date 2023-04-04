using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classemployee
{
    class student
    {
        public int id,mobno;
        public string name;
        public float salary;
    }
    class program
    {
        static void Main(string[] args)
        {
            student employee1 = new student();
            employee1.id= 123;
            employee1.name = "tanu";
            employee1 .salary=35000;
            employee1.mobno = 1234555;
            Console.WriteLine("rno" + employee1.id);
            Console.WriteLine("name" + employee1.name);
            Console.WriteLine("salary" + employee1.salary);
            Console.WriteLine("monno" + employee1.mobno);
            Console.ReadLine();
        }
    }
}
    
