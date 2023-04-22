using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BODMAS4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 2, k = 3;
            int z = ((2 * x) + (4 * y) + 9) / (9 * k - 2);
            Console.WriteLine(z);
            Console.ReadLine();
       }
    }
}
