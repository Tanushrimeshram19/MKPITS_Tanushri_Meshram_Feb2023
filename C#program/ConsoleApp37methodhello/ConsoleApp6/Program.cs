using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("again calling display");
            display();
            Console.WriteLine("again calling display");
            display();
        }
        static void display()
        {
            Console.WriteLine("Hello World");
        }
    }
}
