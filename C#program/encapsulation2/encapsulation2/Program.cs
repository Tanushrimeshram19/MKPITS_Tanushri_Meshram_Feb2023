using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation2
{
    internal class Program
    {
        class employee
        {
            private int empid;
            private string empname;
            public int emp
            {
                get { return empid; }
                set { empid = value; }
            }
            public string emp1
            {
                get { return empname; }
                set { empname = value; }
            }
        }
        class program
        {
            public static void Main(string[] args)
            {
                employee e = new employee();
                e.emp = 1234;
                e.emp1 = "tanu";
                int employeeid = e.emp;
                string empname = e.emp1;
                Console.WriteLine("empolyeename:"  );
                Console.WriteLine("empoyeeid:"+employeeid);
                Console.ReadLine();
            }
        }
    }
}

    