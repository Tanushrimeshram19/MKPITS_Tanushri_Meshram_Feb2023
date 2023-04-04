using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b1;
            Console.Write("entered bit");
            b1=Convert.ToByte(Console.ReadLine());
            Console.WriteLine("byte entered=" + b1);
            Console.ReadKey();
        }
    }
}
