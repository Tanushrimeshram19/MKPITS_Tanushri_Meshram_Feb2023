using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main()
        {
            int num1, num2, num3;
            Console.WriteLine("enter num1");
            Console.WriteLine("enter num2");
            Console.WriteLine("enter num3");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("num 1 is smaller");
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("num2 is smaller");
            }
            else
            {
                Console.WriteLine("num3 is smaller");
            }
            Console.ReadKey();
        }
    }
}
        
   
