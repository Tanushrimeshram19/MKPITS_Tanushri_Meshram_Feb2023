using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order3
{
    class order
    {
        int quantity,price;
        string name;
        public void getdata()
        {

            name = "friedrice";
            quantity = 3;
            price = 220;




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
            order order1 = new order();
            order1.getdata();
            order1.displaydata();
            Console.ReadKey();
        }
    }
}


    
