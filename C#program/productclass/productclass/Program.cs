using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productclass
{
    class product
    {
        public int quantity,price;
        public string name;
    }
    class program
    {
        static void Main(string[] args)
        {
            product pro = new product();
            pro.name = "washing machine";
            pro.quantity = 1;
            pro.price = 45000;
            Console.WriteLine("name" + pro.name);
            Console.WriteLine("qantity" + pro.quantity);
            Console.WriteLine("price" + pro.price);
            Console.ReadLine();
        }
    }
}

    
