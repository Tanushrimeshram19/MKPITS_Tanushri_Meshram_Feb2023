using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading2
{
    class employee
    {
        int empno;
        string empname;
        public void getdata(string empname, int empno)
        {
           
            this.empname = "tanu";
            this.empno = empno;
        }
        public void getdata(int empno, string empname)
        {
            this.empno = empno;
            this.empname = "ravish";
        }


        public void display()
        {
            Console.WriteLine("empno" + empno);
            Console.WriteLine("empname" + empname);

        }
        class program
        {
            static void Main(string[] args)
            {
                employee emp = new employee();
                emp.getdata("tanu", 111);
                Console.WriteLine("employee 1 details:");
                emp.display();
                employee emp1 = new employee();
                emp1.getdata("ravish", 222);
                Console.WriteLine("employee 2 details:");
                emp1.display();
                Console.ReadLine();

            }
        }
    }
}

    

