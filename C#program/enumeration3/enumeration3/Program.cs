using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeration3
{
    
    
        enum Colors
    {
        Red,
        Green,
        Blue,
        Yellow,
        Orange
    }

    class Program
    {
        static void Main(string[] args)
        {

            Colors favoriteColor = Colors.Blue;
           
            Console.WriteLine("My favorite color is " + favoriteColor);
            Console.ReadLine();
        }
    }
}
    
