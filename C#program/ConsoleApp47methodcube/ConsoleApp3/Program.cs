using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calling method");
            int result = calculatecube();
            Console.WriteLine("cube=" + result);
            Console.ReadLine();
        }
        static int calculatecube()
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            int cube = num * num*num;
            return cube;
        }
    }
}
