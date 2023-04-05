using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car3
{

    class car
    {
        int price, speed;
        string name, color;
        public void getdata(string name, string color,int price,int speed)
        {
            name = "swift";
            color = "white";
            price = 80000;
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
            car1.getdata("swift", "white", 700000, 80);
            car1.displaydata();
            Console.ReadLine();
        }
    }
}
    
    

    
    
    
