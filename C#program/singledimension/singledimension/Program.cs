using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singledimension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter number");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("num [ {0} ]={1}", i, num[i]);
               
            }
        }
    }
}

