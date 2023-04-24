using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialnumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int factorial, num;
            Console.WriteLine("enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            obj .factorial(num);
            Console.WriteLine("factorial of {0} is {1} ;num,fact");
        }
        public int factorial(int num)
        {
            if (num == 0)
                return 1;
            else
                return num * factorial(num - 1);
        }
    }
}



        

