using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productname;
            int productrate, productquantity, totalamount, discount;
            Console.WriteLine("enter productrate");
            productrate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter quantity");
            productquantity = Convert.ToInt32(Console.ReadLine());
            totalamount = productrate * productquantity;

            Console.WriteLine("totalamount=" + totalamount);
            if (totalamount >= 2000)
            {
            }

            else if (totalamount < 2000)
            {
                discount = (10 * totalamount) / 100;
                Console.WriteLine("10%discount of rs" + discount);
            }
            else
            {
                discount = 0;
                Console.WriteLine("no discount");
            }
                Console.ReadLine();
            }
        }

    }


        
   
