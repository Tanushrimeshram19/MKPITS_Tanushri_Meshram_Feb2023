using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverloading
{
    class employee
    {
        int empno;
        string empname;
        public void getdata(int empno)
        {
            this.empno = empno;
            this.empname = "tanu";
        }
        public void getdata(int empno, string empname)
        {
            this.empno = empno;
            this.empname = empname;
        }
        public void display()
        {
            Console.WriteLine("empno" + empno);
            Console.WriteLine("empname" + empname);
        }
    }
    class program
    {
        static void Main(string[] args) 
        { 
            employee employee = new employee();
            employee.getdata(123);
            employee.display();
            employee.getdata(33, "ravish");
            employee.display();
            Console.ReadLine();
        }
    }

    }
   
