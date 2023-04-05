using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer4
{
    class customer
    {
        int id, mobno;
        string name,address;
        public void getdata( string name,string address, int id,int mobno)
        {
            name = name;
            address = address;
            id = id;
            mobno = mobno;

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
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter address");
            string address = Console.ReadLine();
            Console.WriteLine("enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter mobno");
            int mobno = Convert.ToInt32(Console.ReadLine());
            cust.getdata("name","address",id,mobno);
            cust.displaydata();
            Console.ReadLine();

        }
    }
}


    

   
