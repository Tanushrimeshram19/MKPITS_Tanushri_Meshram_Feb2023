using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productfieldmethodparameter
{
    class product
    {
        int quantity, price;
        string name;
        public void getdata( string name, int quantity,int price)
        {
            name = "washing machine";
            quantity = 1;
            price = 50000;
            
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
            pro.getdata("washingmachine",1,50000);
            pro.displaydata();
            Console.ReadLine();
        }
    }
}
    
    

    
