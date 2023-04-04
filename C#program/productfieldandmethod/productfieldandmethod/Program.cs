using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productfieldandmethod
{
    class product
    {
        int quantity, price;
        string name;
        public void getdata()
        {
           name = "washing machine";
            quantity = 1;
            price = 67000;
        }
        public void displaydata()
        {
            Console.WriteLine("name" + name);
            Console.WriteLine("quantity" + quantity);
            Console.WriteLine("price" + price);
            
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            product pro = new product();
            pro.getdata();
            pro.displaydata();
            Console.ReadLine();
        }
    }
}
    
