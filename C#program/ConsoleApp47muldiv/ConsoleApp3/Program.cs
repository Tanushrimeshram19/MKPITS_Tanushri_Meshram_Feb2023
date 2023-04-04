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
            int num1, num2, result;
            Console.WriteLine("enter number1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("multiplying a multilplication");
            result = multiplication(num1, num2);
            Console.WriteLine("multiplication=" + result);
            Console.WriteLine("calling division");
            result = division(num1, num2);
            Console.WriteLine("division=" + result);
            Console.ReadLine();
        }
        static int multiplication(int n1, int n2)
        {
            int result = n1 * n2;
            return result;
        }
        static int division(int n1, int n2)
        {
            int result = n1 % n2;
            return result;

        }
    }
}
