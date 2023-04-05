using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer2
{
    class customer
    {
        int id,  mobno;
        string name,address;
        public void getdata()
        {
           
            name = "tanu";
            id = 123;
            address = "nagpur";
            mobno = 45679;

            
        }
        public void displaydata()
        {
            Console.WriteLine("name" + name);
            Console.WriteLine("id" + id);
            Console.WriteLine("address" + address);
            Console.WriteLine("mobno" + mobno);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            customer cust = new customer();
            cust.getdata();
            cust.displaydata();
            Console.ReadKey();
        }
    }
}
    