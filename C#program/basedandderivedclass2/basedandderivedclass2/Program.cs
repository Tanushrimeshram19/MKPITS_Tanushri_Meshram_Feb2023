using basedandderivedclass2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace basedandderivedclass2
{
    class person
    {
        string name;
        string address;
        public void getdata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine("name" + name);
            Console.WriteLine("address" + address);
        }
    }
    class customer : person
    {
        int custid;
        public void getdata(int custid,string name,string address)
        {
            this.custid = custid;
            getdata("name","address");
            
        }
        public void display()
        {
            base.display();
            Console.WriteLine("custid" + custid);
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            customer cust = new customer();
            cust.getdata(123, "amit", "nagpur");
            cust.display();
            Console.ReadKey();
        }
    }
}

