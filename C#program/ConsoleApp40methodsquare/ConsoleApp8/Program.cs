using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calling method");
            int result = calculatesquare();
            Console.WriteLine("square=" + result);
            Console.ReadLine();
        }
        static int calculatesquare()
        {
            int num;
            Console.WriteLine("enter num");
            num=Convert.ToInt32(Console.ReadLine());
            int square = num * num;
            return square;

        }
    }
}
