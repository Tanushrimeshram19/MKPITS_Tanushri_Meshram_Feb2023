using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiseg2
{
    
    class employee
    {
        int empid;
        string empname;

        public void getdata(int rno, string name)
        {
            this.empid = id;
            this.empname = name;
        }
        public void displaydata()
        {

            Console.WriteLine("id " + empid);
            Console.WriteLine("name " + empname);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee();
            Console.WriteLine("enter empid");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter empname");
            string name = Console.ReadLine();

            emp1.getdata(id ,name);
            emp1.displaydata();
        }
    }
}


