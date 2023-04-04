using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productmethodfielduser
{
    class product
    {
        int quantity, price;
        string name;
        public void getdata(string name,int qunatity,int price)
        {
            name = name;
            quantity = quantity;
            price = price;

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
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter qunatity);
            int quantity = Console.ToInt32(Console.ReadLine());
            Console.WriteLine("enter price");
            int price = Convert.ToInt32(Console.ReadLine());
            pro.getdata(name,quantity,price);
            pro.displaydata();
            Console.ReadLine();

        }
    }
}


    

    
