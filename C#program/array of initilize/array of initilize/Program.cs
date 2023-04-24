using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_of_initilize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            for (int i=0;i<5;i++)
            {
                Console.WriteLine("num[{1}]", i, num[i]);
                Console.ReadLine();
            }
        }
    }
}
