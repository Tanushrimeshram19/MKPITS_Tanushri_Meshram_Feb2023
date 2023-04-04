using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("enter the number:");
            i=int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("entered number is an even number");
            }
            else
            {
                Console.WriteLine("entered number iss odd");
                Console.ReadLine();
            }
        }
    }
}
