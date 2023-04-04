using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter num");
            num=Convert.ToInt32(Console.ReadLine());
            table(num);
            Console.ReadKey();
        }
        static int table(int num)
        {
            for (int j=1; j<=10; j++)
            {
                int mul = num * j;
                Console.Write(mul);
            }
            return(num);
        }
    }
}
