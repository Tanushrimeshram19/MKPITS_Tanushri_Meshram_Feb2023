using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car2
{
    class car
    {
        int price, speed;
        string name, color;
        public void getdata()
        {

            name = "swift";
            color = "white";
            price = 700000;
            speed = 80;




        }
        public void displaydata()
        {
            Console.WriteLine("name" + name);
            Console.WriteLine("color" + color);
            Console.WriteLine("price" + price);
            Console.WriteLine("speed" + speed);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car1.getdata();
            car1.displaydata();
            Console.ReadKey();
        }
    }
}
    
    
