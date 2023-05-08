using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedclass
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
            sealed class Rectangle
        {
            private double length;
            private double width;

            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
            }

            public double GetArea()
            {
                return length * width;
                Console.ReadLine();
            }
        }
    }
}







