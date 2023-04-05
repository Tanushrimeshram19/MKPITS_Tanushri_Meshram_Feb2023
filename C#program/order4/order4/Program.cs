using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order4
{
    class order
    {
        int quantity, price;
        string name;
        public void getdata(string name, string address, int id, int mobno)
        {
            name = "noodles";
            quantity = 4;
            price = 350;

        }
        public void displaydata()
        {
            Console.WriteLine("name" + name);
            Console.WriteLine("quantity" +quantity);
            Console.WriteLine("price" + price);
            

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            order order1 = new order();
            order1.getdata("noodles",4,350);
            order1.displaydata();
            Console.ReadLine();
        }
    }
}
    
    

    
    
    
