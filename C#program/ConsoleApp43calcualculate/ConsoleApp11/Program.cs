using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculate();
        }
        static void calculate()
        {
            int num1, num2 ;
            Console.WriteLine("enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("adding addition");
            addition(num1 , num2);
            subtraction(num1 , num2);
            
            Console.WriteLine("calling subtraction");
            Console.ReadKey();
        }
        static  void addition(int n1, int n2)
        {
            int result = n1 + n2;
            Console.WriteLine("addition is=" + result);
            
        }
        static void subtraction(int n1, int n2)
        {
            int result = n1 - n2;
            Console.WriteLine("subtraction is=" + result);
            
        }
    }
}

       
