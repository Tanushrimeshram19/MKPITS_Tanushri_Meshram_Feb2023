using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basedandderivedclass1
{
    internal class Program
    {
        class person
        {
            public string name;
            public string address;
            public void getpersondata(string name, string address)
            {

                this.name = name;
                this.address = address;
            }
            public void displaypersondata()
            {

                Console.WriteLine("empname " + name);
                Console.WriteLine("emp addres " + address);

            }


        }
        
        class employee : person
        {

            public int empno;
            public int salary;
            public void getemployeedata(int empno, int salary)
            {
                this.empno = empno;
                this.salary = salary;

            }
            public void displayemployeedata()
            {
                Console.WriteLine("empno " + empno);
                Console.WriteLine("salary " + salary);
            }
        }


        class program
        {
            static void Main(string[] args)
            {

                employee emp = new employee();
                emp.getpersondata("tanu", "nagpur");
                emp.getemployeedata(333, 9999);
                emp.displayemployeedata();
                emp.displaypersondata();
                Console.ReadLine();




            }
        }

    }
}

