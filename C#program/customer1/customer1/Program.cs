using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer1
{
    class customer
    {
        public int  mobno,id;
        public string name,address;
        
    }
    class program
    {
        static void Main(string[] args)
        {
            customer customer1 = new customer();
            customer1.name = "tanu";
            customer1.address = "nagpur";
            customer1.mobno = 889065;
            customer1.id = 123;
            Console.WriteLine("name" + customer1.name);
            Console.WriteLine("address" + customer1.address);
            Console.WriteLine("mobno" + customer1.mobno);
            Console.WriteLine("id" + customer1.id);
            Console.ReadLine();
        }
    }
}
    
    
