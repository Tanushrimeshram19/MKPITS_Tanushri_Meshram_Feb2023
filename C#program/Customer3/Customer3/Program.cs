using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer3
{
    class customer
    {
        int id, mobno;
        string name,address;
        public void getdata(string name, string address,int id,int mobno)
        {
            name = "tanu";
            address = "nagpur";
            id = 123;
            mobno = 98788;

        }
        public void displaydata()
        {
            Console.WriteLine("name" + name);
            Console.WriteLine("address" + address);
            Console.WriteLine("id" + id);
            Console.WriteLine("mobno" + mobno);

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            customer cust = new customer();
            cust.getdata("tanu", "nagpur",123,98788);
            cust.displaydata();
            Console.ReadLine();
        }
    }
}
    
    

    
    
