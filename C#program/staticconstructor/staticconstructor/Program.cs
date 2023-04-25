using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticconstructor
{
    public class calculate
    {
        public static float pi;
        static calculate()
        {
            pi = 3.14f;
            Console.WriteLine("static constructor called");
        }
        public void display()
        {
            Console.WriteLine("rate of intrest" + pi);
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            calculate c1 = new calculate();
            calculate c2 = new calculate();
            c1.display();
            c2.display();
            Console.ReadLine();
        }
    }
}