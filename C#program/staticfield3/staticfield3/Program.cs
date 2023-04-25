using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticfield3
{
    class employee
    {
        public int empno;
        public string name;
        public static string Companyname = "Torona";
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
                int empno;
                Console.WriteLine("enter empno");
                empno = Convert.ToInt32(Console.ReadLine());
                string name;
                Console.WriteLine(" enter name");
                name= Console.ReadLine();

                int empno1;
                Console.WriteLine("enter empno");
                empno1 = Convert.ToInt32(Console.ReadLine());
                string name1;
                Console.WriteLine(" enter name");
                name1 = Console.ReadLine();

                employee emp =new employee(empno,name);
                employee emp1=new employee(empno1, name1);
                emp.display();
                emp1.display();


            }
        }
    }

}

    
