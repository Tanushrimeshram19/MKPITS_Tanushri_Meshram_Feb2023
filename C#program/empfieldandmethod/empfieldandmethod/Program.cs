using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empfieldandmethod
{
    class employee
    {
        int id,salary,mobno;
        string name;
        public void getdata()
        {
            id = 123;
            name = "tanu";
            salary = 70000;
            mobno = 34567899;
        }
        public void displaydata()
        {
            Console.WriteLine("id" + id);
            Console.WriteLine("name" + name);
            Console.WriteLine("salary" + salary);
            Console.WriteLine("mobno" + mobno);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
             employee emp= new employee();
            emp.getdata();
            emp.displaydata();
            Console.ReadLine();
        }
    }
}