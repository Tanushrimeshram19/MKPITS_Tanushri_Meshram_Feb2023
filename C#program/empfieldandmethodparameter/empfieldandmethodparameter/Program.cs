using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empfieldandmethodparameter
{
    class employee
    {
        int id, salary, mobno;
        string name;
        public void getdata(int i, string n,int m,int s)
        {
            id = 199;
            name = "tanu";
            salary = 90000;
            mobno = 456789;
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
            emp.getdata(199, "tanu",90000,456789);
            emp.displaydata();
            Console.ReadLine();
        }
    }
}
    
    
