using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car4
{
    class car
    {
        int price, speed;
        string name, color;
        public void getdata(string name, string color, int price, int speed)
        {
            name = name;
            color = color;
            price = price;
            speed = speed;

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
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter color");
            string color = Console.ReadLine();
            Console.WriteLine("enter price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter speed");
            int speed = Convert.ToInt32(Console.ReadLine());
            car1.getdata("name", "color", 700000,80);
            car1.displaydata();
            Console.ReadLine();

        }
    }
}


    

   
    
