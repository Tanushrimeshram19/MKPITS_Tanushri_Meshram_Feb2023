using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancechildclass
{
    internal class Program
    {
        class person
        {
            public string name;
            public string address;
        }
        class employee : person
        {
            public int empno;
            public int salary;
        }
        class program
        {
            static void Main(string[] args)
            {
                employee emp = new employee();
                emp.empno = 1;
                emp.name = "tanu";
                emp.address = "nagpur";
                emp.salary = 60000;
                Console.WriteLine("empno" + emp.empno);
                Console.WriteLine("empname" + emp.name);
                Console.WriteLine("empaddress" + emp.address);
                Console.WriteLine("empsalary" + emp.salary);
                Console.ReadLine();
            }
        }
    }
}


                    
            
