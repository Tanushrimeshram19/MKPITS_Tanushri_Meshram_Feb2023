using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticfield2
{
    class employee
    {
        public int empno;
        public string name;
        public static string Companyname="Torona";
        public employee(int empno, string name)
        {
            this.empno = empno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("empno" + empno);
            Console.WriteLine("name" + name);
            Console.WriteLine("Company name" + Companyname);
        }
        class program
        {
            public static void Main(string[] args)
            {
                employee a1 = new employee(123, "tanu");
                employee a2 = new employee(345, " manish");
                a1.display();
                a2.display();
                Console.ReadLine();


            }
        }
    }

}


   
