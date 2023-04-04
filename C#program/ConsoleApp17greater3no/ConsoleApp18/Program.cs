using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main()
        {
            int num1, num2, num3;
            Console.WriteLine("enter num 1");
            Console.WriteLine("enter num 2");
            Console.WriteLine("enter num 3");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
                   if (num1 > num2)
                {
                Console.WriteLine("Num 1 is greater");
            }
           else if (num2 > num3 && num2>num1) 
            {
                Console.WriteLine("Num 2 is greater");
            }
                 else
            {
                Console.WriteLine("Num 3 is greater");
            }
            Console.ReadKey();
        }
    }
}

