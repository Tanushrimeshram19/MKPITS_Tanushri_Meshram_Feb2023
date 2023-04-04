using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empmethodfielduser
{
    class employee
    {
        int id,mobno,salary;
        string name;
        public void getdata(int id, string name,int mobno,int salary)
        {
            id= id;
            name = name;
            mobno = mobno;
            salary = salary;

        }
        public void displaydata()
        {
            Console.WriteLine("id" + id);
            Console.WriteLine("name" + name);
            Console.WriteLine("mobno" + mobno);
            Console.WriteLine("salary" + salary);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            Console.WriteLine("enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter mobno");
            int mobno= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter salary");
            int salary= Convert.ToInt32(Console.ReadLine());
            emp.getdata(id, name,mobno,salary);
            emp.displaydata();
            Console.ReadLine();

        }
    }
}


    
