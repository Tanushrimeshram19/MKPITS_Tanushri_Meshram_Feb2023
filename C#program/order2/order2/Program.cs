using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order2
{
    class order
    {
        public int quantity, price;
        public string name;

    }
    class program
    {
        static void Main(string[] args)
        {
            order order1 = new order();
            order1.name = "friedrice";
            order1.quantity = 2;
            order1.price = 140 ;
            Console.WriteLine("name" + order1.name);
            Console.WriteLine("quantity" + order1.quantity);
            Console.WriteLine("price" + order1.price);
            Console.ReadLine();
        }
    }
}
    
    
   
