using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car1
{
    class car
    {
        public int price, speed;
        public string name, color;

    }
    class program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car1.name = "swift";
            car1.color = "white";
            car1.price= 700000;
            car1.speed= 100;
            Console.WriteLine("name" + car1.name);
            Console.WriteLine("color" + car1.color);
            Console.WriteLine("price" + car1.price);
            Console.WriteLine("speed" + car1.speed);
            Console.ReadLine();
        }
    }
}
    
    

    
